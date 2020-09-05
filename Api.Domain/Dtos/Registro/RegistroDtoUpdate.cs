using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Registro
{
    public class RegistroDtoUpdate
    {
        
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Data é campo Obrigatorio")]
        public DateTime Data { get; set; }

        public string Tipo { get; set; }

        public Guid UsuarioId { get; set; }
    }
}
