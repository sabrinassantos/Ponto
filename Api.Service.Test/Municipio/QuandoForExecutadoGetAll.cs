using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.Registro;
using Api.Domain.Interfaces.Services.Registro;
using Moq;
using Xunit;

namespace Api.Service.Test.Municipio
{
    public class QuandoForExecutadoGetAll : MunicipioTestes
    {
        private IRegistroService _service;
        private Mock<IRegistroService> _serviceMock;

        [Fact(DisplayName = "É Possivel Executar o Método GETAll.")]
        public async Task E_Possivel_Executar_Metodo_GetAll()
        {
            _serviceMock = new Mock<IRegistroService>();
            _serviceMock.Setup(m => m.GetAll()).ReturnsAsync(listaDto);
            _service = _serviceMock.Object;

            var result = await _service.GetAll();
            Assert.NotNull(result);
            Assert.True(result.Count() == 10);

            var _listResult = new List<RegistroDto>();
            _serviceMock = new Mock<IRegistroService>();
            _serviceMock.Setup(m => m.GetAll()).ReturnsAsync(_listResult.AsEnumerable);
            _service = _serviceMock.Object;

            var _resultEmpty = await _service.GetAll();
            Assert.Empty(_resultEmpty);
            Assert.True(_resultEmpty.Count() == 0);
        }
    }
}
