using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Registro;

namespace Api.Domain.Interfaces.Services.Registro
{
    public interface IRegistroService
    {
        Task<RegistroDto> Get(Guid id);
        Task<RegistroDtoCompleto> GetCompleteByUsuario(Guid id);
        Task<IEnumerable<RegistroDto>> GetAll();
        Task<RegistroDtoCreateResult> Post(RegistroDtoCreate registro);
        Task<RegistroDtoUpdateResult> Put(RegistroDtoUpdate registro);
        Task<bool> Delete(Guid id);
    }
}
