namespace Api.Domain.Models
{
    public class UsuarioModel : BaseModel
    {

        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

    }
}
