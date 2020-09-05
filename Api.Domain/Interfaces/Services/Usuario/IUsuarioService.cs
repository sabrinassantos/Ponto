using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Usuario;

namespace Api.Domain.Interfaces.Services.Usuario
{
    public interface IUsuarioService
    {
        Task<UsuarioDto> Get(Guid id);
        Task<IEnumerable<UsuarioDto>> GetAll();
        Task<UsuarioDtoCreateResult> Post(UsuarioDtoCreate user);
    }
}
