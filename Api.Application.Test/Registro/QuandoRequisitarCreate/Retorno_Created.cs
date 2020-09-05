using System;
using System.Threading.Tasks;
using Api.Application.Controllers;
using Api.Domain.Dtos.Registro;
using Api.Domain.Interfaces.Services.Registro;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace Api.Application.Test.Municipio.QuandoRequisitarCreate
{
    public class Retorno_Created
    {
        //private RegistroController _controller;

        //[Fact(DisplayName = "É possível Realizar o Created.")]
        //public async Task E_Possivel_Invocar_a_Controller_Create()
        //{
        //    var serviceMock = new Mock<IRegistroService>();
        //    serviceMock.Setup(m => m.Post(It.IsAny<RegistroDtoCreate>())).ReturnsAsync(
        //        new RegistroDtoCreateResult
        //        {
        //            Id = Guid.NewGuid()
        //        }
        //    );

        //    _controller = new RegistroController(serviceMock.Object);

        //    Mock<IUrlHelper> url = new Mock<IUrlHelper>();
        //    url.Setup(x => x.Link(It.IsAny<string>(), It.IsAny<object>())).Returns("http://localhost:5000");
        //    _controller.Url = url.Object;

        //    var municipioDtoCreate = new RegistroDtoCreate
        //    {
        //        Data = "São Paulo",
        //        CodIBGE = 1
        //    };

        //    var result = await _controller.Post(municipioDtoCreate);
        //    Assert.True(result is CreatedResult);

       // }

    }
}
