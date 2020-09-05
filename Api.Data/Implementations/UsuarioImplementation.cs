using System.Linq;
using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class UsuarioImplementation : BaseRepository<UsuarioEntity>, IUsuarioRepository
    {
        private DbSet<UsuarioEntity> _dataset;

        public UsuarioImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<UsuarioEntity>();
        }
    }
}
