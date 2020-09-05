using System;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;

namespace Api.Domain.Repository
{
    /// <summary>
    /// criação de classes bases, procuram respeitar o princípio e aberto e fechado, 
    ///para que modificações que precisem de comportamento diferente, sejam estendidas e não alteradas na classe base
    /// </summary>
    public interface IRegistroRepository : IRepository<RegistroEntity>
    {
        Task<RegistroEntity> GetCompleteByUsuario(Guid id);
    }
}
