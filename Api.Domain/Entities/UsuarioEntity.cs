using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class UsuarioEntity : BaseEntity
    {
      
        [Required]
        [MaxLength(45)]
        public string Nome { get; set; }

        public IEnumerable<RegistroEntity> Registros { get; set; }
    }
}
