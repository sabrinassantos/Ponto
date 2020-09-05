using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Registro
{
    public class RegistroDtoCreate
    {
        public DateTime Data { get; set; }
        public string Tipo { get; set; }
        public Guid UsuarioId { get; set; }
    }
}
