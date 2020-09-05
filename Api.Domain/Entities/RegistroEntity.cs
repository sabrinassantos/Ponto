using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class RegistroEntity : BaseEntity
    {
      
        public DateTime Data { get; set; }

        [Required]
        public Guid UsuarioId { get; set; }
        public string Tipo { get; set; }
        public UsuarioEntity Usuario { get; set; }

    }
}
