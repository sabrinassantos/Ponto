using System;

namespace Api.Domain.Dtos.Registro
{
    public class RegistroDtoCreateResult
    {
        public Guid Id { get; set; }
        public DateTime Data { get; set; }
        public string Tipo { get; set; }
        public Guid UsuarioId { get; set; }
    }
}
