using System;

namespace Api.Domain.Dtos.Registro
{
    //Aplica��o do item de responsabilidade �nica do padr�o SOLID, criando classes de espec�ficas do objeto
    //para insert, update e apresenta��o
    public class RegistroDto
    {
        public Guid Id { get; set; }
        public DateTime Data { get; set; }
        public string Tipo { get; set; }
        public Guid IdUsuario { get; set; }
    }
}
