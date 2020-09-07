using System;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Dtos.Registro;
using Api.Domain.Interfaces.Services.Registro;
using application.Controllers;
using Domain.Extensions;
using Domain.Interfaces.Services.Notificador;
using Domain.Interfaces.Services.User;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    /// <summary>
    /// Apliquei o item de responsabilidade única criando classes do usuário e registro para parâmetros de entrada, para atualização e criação, e tb para os retornos e também para que cada classe possua somente suas responsabilidades.
    ///    A criação de classes bases, procuram respeitar o princípio e aberto e fechado, para que modificações que precisem de comportamento diferente, sejam estendidas e não alteradas na classe base.
    ///O princípio da segregação da interface foi aplicada na criação de interfaces específicas para que uma classe não seja forçada a implementar métodos que não serão necessários
    ///Utilizei também injeção de dependência para que os módulos dependam somente de abstração.
    //Foi aplicado a arquitetura DDD, separando as camadas de dados, domínio(negócio) ,  transversais e aplicação.
    /// </summary>
    /// 
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroController : MainController
    {
        public IRegistroService _service { get; set; }
        public RegistroController(IRegistroService service,
                                   INotificador notificador,
                                   IUser user) : base(notificador, user)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await _service.GetAll());
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [ClaimsAuthorize("Supervisor", "Listar")]
        [HttpGet]
        [Route("{id}", Name = "GetRegistrosPorUsuarioId")]
        public async Task<ActionResult> Get(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _service.Get(id);
                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

       

        [HttpPost]
        public async Task<ActionResult<RegistroDtoCreateResult>> Post([FromBody] RegistroDtoCreate dtoCreate)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);
            
            try
            {
                var result = await _service.Post(dtoCreate);
                return CustomResponse(dtoCreate);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] RegistroDtoUpdate dtoUpdate)
        {

            if (!ModelState.IsValid) return CustomResponse(ModelState);

            try
            {
                var result = await _service.Put(dtoUpdate);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);
            try
            {
                return Ok(await _service.Delete(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }


    }
}
