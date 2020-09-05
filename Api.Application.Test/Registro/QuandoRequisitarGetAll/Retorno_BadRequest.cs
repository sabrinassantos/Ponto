using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Application.Controllers;
using Api.Domain.Dtos.Registro;
using Api.Domain.Interfaces.Services.Registro;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace Api.Application.Test.Municipio.QuandoRequisitarGetAll
{
    public class Retorno_BadRequest
    {
        private RegistroController _controller;

    //    [Fact(DisplayName = "É possível Realizar o GetAll.")]
    //    public async Task E_Possivel_Invocar_a_Controller_GetAll()
    //    {
    //        var serviceMock = new Mock<IRegistroService>();
    //        serviceMock.Setup(m => m.GetAll()).ReturnsAsync(
    //             new List<RegistroDto>
    //             {
    //                new RegistroDto
    //                {
    //                    Id = Guid.NewGuid(),
    //                    Nome = "São Paulo",
    //                },
    //                new RegistroDto
    //                {
    //                    Id = Guid.NewGuid(),
    //                    Nome = "Limeira",
    //                }
    //             }
    //        );

    //        _controller = new RegistroController(serviceMock.Object);
    //        _controller.ModelState.AddModelError("Id", "Formato Invalido");

    //        var result = await _controller.GetAll();
    //        Assert.True(result is BadRequestObjectResult);

    //    }
    //}
}
