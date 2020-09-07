using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Dtos.User;
using Domain.Interfaces.Services.Notificador;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace application.Controllers.v1
{
    [Route("api")]
    [ApiController]
    public class AuthController : MainController
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        public AuthController(INotificador notificador,
            SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager) : base(notificador)
        {
            _signInManager = signInManager;
            _userManager = userManager;
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
                return CustomResponse(userDtoRegister);
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
                
                return CustomResponse(userDtoLogin);
            }
            if (result.IsLockedOut)
            {
                NotificarErro("Usuário temporariamente bloqueado por tentativas inválidas");
                return CustomResponse(userDtoLogin);
            }

            NotificarErro("Usuário ou Senha incorretos");
            return CustomResponse(userDtoLogin);

        }
    }
}
