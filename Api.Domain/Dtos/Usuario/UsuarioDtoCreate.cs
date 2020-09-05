using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Usuario
{
    public class UsuarioDtoCreate
    {
        [Required(ErrorMessage = "Nome é um campo obrigatório")]
        [StringLength(60, ErrorMessage = "Nome deve ter no máximo {1} caracteres.")]
        public string Name { get; set; }

        public string Email { get; set; }


    }
}
