using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Domain.Entities
{
    /// <summary>
    /// criação de classes bases, procuram respeitar o princípio e aberto e fechado, 
    ///para que modificações que precisem de comportamento diferente, sejam estendidas e não alteradas na classe base
    /// </summary>
    
    public abstract class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        private DateTime? _createAt;
        public DateTime? CreateAt
        {
            get { return _createAt; }
            set { _createAt = (value == null ? DateTime.UtcNow : value); }
        }

        public DateTime? UpdateAt { get; set; }

    }
}
