using System;
using Api.Domain.Dtos.Usuario;

namespace Api.Domain.Dtos.Registro
{
    public class RegistroDtoCompleto
    {
        public Guid Id { get; set; }
        public DateTime Data { get; set; }
        public string Tipo { get; set; }
        public Guid IdUsuario { get; set; }
        public UsuarioDto Usuario { get; set; }

    }
}
