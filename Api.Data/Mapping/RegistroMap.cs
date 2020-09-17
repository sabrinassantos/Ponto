using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class RegistroMap : IEntityTypeConfiguration<RegistroEntity>
    {
        public void Configure(EntityTypeBuilder<RegistroEntity> builder)
        {
            builder.ToTable("Registro");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.Data);

            builder.Property(u => u.Tipo);

            builder.HasOne(u => u.Usuario)
                   .WithMany(m => m.Registros);



        }
    }
}
