using System.Threading.Tasks;
using Api.Domain.Interfaces.Services.Registro;
using Moq;
using Xunit;

namespace Api.Service.Test.Municipio
{
    public class QuandoForExecutadoGetCompleteById : MunicipioTestes
    {
        private IRegistroService _service;
        private Mock<IRegistroService> _serviceMock;

        //[Fact(DisplayName = "É Possivel Executar o Método GET Complete By Id.")]
        //public async Task E_Possivel_Executar_Metodo_Get_Complete_by_Id()
        //{
        //    _serviceMock = new Mock<IRegistroService>();
        //    _serviceMock.Setup(m => m.GetCompleteById(IdMunicipio)).ReturnsAsync(municipioDtoCompleto);
        //    _service = _serviceMock.Object;

        //    var result = await _service.GetCompleteById(IdMunicipio);
        //    Assert.NotNull(result);
        //    Assert.True(result.Id == IdMunicipio);
        //    Assert.Equal(NomeMunicipio, result.Nome);
        //    Assert.Equal(CodigoIBGEMunicipio, result.CodIBGE);
        //    Assert.NotNull(result.Uf);
        //}
    }
}
