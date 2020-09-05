using System;
using System.Linq;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class RegistroImplementation : BaseRepository<RegistroEntity>, IRegistroRepository
    {
        private DbSet<RegistroEntity> _dataset;

        public RegistroImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<RegistroEntity>();
        }


        public async Task<RegistroEntity> GetCompleteByUsuario(Guid id)
        {
            return await _dataset.Include(m => m.Usuario)
                                 .FirstOrDefaultAsync(m => m.Id.Equals(id));
        }
    }
}
