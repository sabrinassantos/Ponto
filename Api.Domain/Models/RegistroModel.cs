using System;

namespace Api.Domain.Models
{
    public class RegistroModel : BaseModel
    {
        private DateTime _data;
        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }
        }

        private string _tipo;
        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        private Guid _idUsuario;
        public Guid UsuarioId
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }
    }
}
