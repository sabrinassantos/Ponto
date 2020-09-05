using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Usuario
{
    public class UsuarioDtoUpdate
    {
        [Required(ErrorMessage = "Id é um campo obrigatório")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome é um campo obrigatório")]
        [StringLength(60, ErrorMessage = "Nome deve ter no máximo {1} caracteres.")]
        public string Name { get; set; }

        
    }
}
