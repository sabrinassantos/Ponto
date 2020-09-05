using System;

namespace Api.Domain.Dtos.Usuario
{
    public class UsuarioDtoUpdateResult
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
