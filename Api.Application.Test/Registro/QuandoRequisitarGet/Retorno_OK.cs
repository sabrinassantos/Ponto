using System;
using System.Threading.Tasks;
using Api.Application.Controllers;
using Api.Domain.Dtos.Registro;
using Api.Domain.Interfaces.Services.Registro;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;


namespace Api.Application.Test.Municipio.QuandoRequisitarGet
{
    public class Retorno_OK
    {
        private RegistroController _controller;

        //[Fact(DisplayName = "É possível Realizar o Get.")]
        //public async Task E_Possivel_Invocar_a_Controller_Get()
        //{
        //    var serviceMock = new Mock<IRegistroService>();

        //    serviceMock.Setup(m => m.Get(It.IsAny<Guid>())).ReturnsAsync(
        //         new RegistroDto
        //         {
        //             Id = Guid.NewGuid(),
        //             Nome = "São Paulo",
        //         }
        //    );

        //    _controller = new RegistroController(serviceMock.Object);

        //    var result = await _controller.Get(Guid.NewGuid());
        //    Assert.True(result is OkObjectResult);

        //}
    }
}
