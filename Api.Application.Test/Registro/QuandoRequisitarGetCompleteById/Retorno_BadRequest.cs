using System;
using System.Threading.Tasks;
using Api.Application.Controllers;
using Api.Domain.Dtos.Registro;
using Api.Domain.Interfaces.Services.Registro;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace Api.Application.Test.Municipio.QuandoRequisitarGetCompleteById
{
    public class Retorno_BadRequest
    {
    //    private RegistroController _controller;

    //    [Fact(DisplayName = "É possível Realizar o Get.")]
    //    public async Task E_Possivel_Invocar_a_Controller_Get()
    //    {
    //        var serviceMock = new Mock<IRegistroService>();

    //        serviceMock.Setup(m => m.GetCompleteById(It.IsAny<Guid>())).ReturnsAsync(
    //             new RegistroDtoCompleto
    //             {
    //                 Id = Guid.NewGuid(),
    //                 Nome = "São Paulo",
    //             }
    //        );

    //        _controller = new RegistroController(serviceMock.Object);
    //        _controller.ModelState.AddModelError("Id", "Formato Inválido");

    //        var result = await _controller.GetCompleteById(Guid.NewGuid());
    //        Assert.True(result is BadRequestObjectResult);

    //    }
    //}
}
