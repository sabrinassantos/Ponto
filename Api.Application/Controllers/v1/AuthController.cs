using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Dtos.User;
using Domain.Extensions;
using Domain.Interfaces.Services.Notificador;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace application.Controllers.v1
{
    [Route("api")]
    [ApiController]
    public class AuthController : MainController
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IOptions<AppSettings> appSettings;
        private readonly AppSettings _appSettings;
        public AuthController(INotificador notificador,
                              SignInManager<IdentityUser> signInManager,
                              UserManager<IdentityUser> userManager,
                              IOptions<AppSettings> appSettings) : base(notificador)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _appSettings = appSettings.Value;
        }

        [HttpPost("nova-conta")]
        public async Task<ActionResult> Registrar(UserDtoRegister userDtoRegister)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            var user = new IdentityUser
            {
                UserName = userDtoRegister.Email,
                Email = userDtoRegister.Email,
                EmailConfirmed = true
            };

            var result = await _userManager.CreateAsync(user, userDtoRegister.Password);
            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, false);
                return CustomResponse(GerarJwt());
            }
            foreach (var error in result.Errors)
            {
                NotificarErro(error.Description);
            }

            return CustomResponse(userDtoRegister);
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login(UserDtoLogin userDtoLogin)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);
            var result = await _signInManager.PasswordSignInAsync(userDtoLogin.Email, userDtoLogin.Password, false, true);

            if (result.Succeeded)
            {
                
                return CustomResponse(GerarJwt());
            }
            if (result.IsLockedOut)
            {
                NotificarErro("Usuário temporariamente bloqueado por tentativas inválidas");
                return CustomResponse(userDtoLogin);
            }

            NotificarErro("Usuário ou Senha incorretos");
            return CustomResponse(userDtoLogin);

        }

        private string GerarJwt()
        {
           

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var token = tokenHandler.CreateToken(new SecurityTokenDescriptor
            {
                Issuer = _appSettings.Emissor,
                Audience = _appSettings.ValidoEm,
                Expires = DateTime.UtcNow.AddHours(_appSettings.ExpiracaoHoras),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            });

            var encodedToken = tokenHandler.WriteToken(token);

          
            return encodedToken;
        }

        private static long ToUnixEpochDate(DateTime date)
            => (long)Math.Round((date.ToUniversalTime() - new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero)).TotalSeconds);
    }
}
