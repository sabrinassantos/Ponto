using System;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Seeds
{
    public static class UsuarioSeeds
    {
        public static void Usuarios(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioEntity>().HasData(
                new UsuarioEntity()
                {
                    Id = new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"),
                    Nome = "Teste1 ",
                    CreateAt = DateTime.UtcNow,
                },

                 new UsuarioEntity()
                 {
                     Id = new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"),
                     Nome = "Teste2 ",
                     CreateAt = DateTime.UtcNow,
                 },

                  new UsuarioEntity()
                  {
                      Id = new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"),
                      Nome = "Teste3 ",
                      CreateAt = DateTime.UtcNow,
                  }

            );
        }
    }
}
