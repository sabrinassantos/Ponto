using System;
using Api.Data.Mapping;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<UsuarioEntity> Users { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UsuarioEntity>(new UsuarioMap().Configure);
            modelBuilder.Entity<RegistroEntity>(new RegistroMap().Configure);

            modelBuilder.Entity<UsuarioEntity>().HasData(
                new UsuarioEntity
                {
                    Id = Guid.NewGuid(),
                    Nome = "Administrador",
                    CreateAt = DateTime.Now,
                    UpdateAt = DateTime.Now,
                }
            );

        }

    }
}
