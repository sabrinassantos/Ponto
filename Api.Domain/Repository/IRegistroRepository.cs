using System;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;

namespace Api.Domain.Repository
{
    /// <summary>
    /// cria��o de classes bases, procuram respeitar o princ�pio e aberto e fechado, 
    ///para que modifica��es que precisem de comportamento diferente, sejam estendidas e n�o alteradas na classe base
    /// </summary>
    public interface IRegistroRepository : IRepository<RegistroEntity>
    {
        Task<RegistroEntity> GetCompleteByUsuario(Guid id);
    }
}
