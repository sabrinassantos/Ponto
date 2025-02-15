using System;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Dtos.Registro;
using Api.Domain.Interfaces.Services.Registro;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    /// <summary>
    /// Apliquei o item de responsabilidade �nica criando classes do usu�rio e registro para par�metros de entrada, para atualiza��o e cria��o, e tb para os retornos e tamb�m para que cada classe possua somente suas responsabilidades.
    ///    A cria��o de classes bases, procuram respeitar o princ�pio e aberto e fechado, para que modifica��es que precisem de comportamento diferente, sejam estendidas e n�o alteradas na classe base.
    ///O princ�pio da segrega��o da interface foi aplicada na cria��o de interfaces espec�ficas para que uma classe n�o seja for�ada a implementar m�todos que n�o ser�o necess�rios
    ///Utilizei tamb�m inje��o de depend�ncia para que os m�dulos dependam somente de abstra��o.
    //Foi aplicado a arquitetura DDD, separando as camadas de dados, dom�nio(neg�cio) ,  transversais e aplica��o.
    /// </summary>
    /// 
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroController : ControllerBase
    {
        public IRegistroService _service { get; set; }
        public RegistroController(IRegistroService service)
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
        public async Task<ActionResult> Post([FromBody] RegistroDtoCreate dtoCreate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _service.Post(dtoCreate);
                if (result != null)
                {
                    // return Created(new Uri(Url.Link("GetRegistrosPorUsuarioId", new { id = result.Id })), result);
                    return Ok(new
                    {
                        success = true,
                        data = result
                    });
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

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] RegistroDtoUpdate dtoUpdate)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

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
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
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
