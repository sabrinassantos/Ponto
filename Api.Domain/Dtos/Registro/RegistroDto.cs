using System;

namespace Api.Domain.Dtos.Registro
{
    //Aplicação do item de responsabilidade única do padrão SOLID, criando classes de específicas do objeto
    //para insert, update e apresentação
    public class RegistroDto
    {
        public Guid Id { get; set; }
        public DateTime Data { get; set; }
        public string Tipo { get; set; }
        public Guid IdUsuario { get; set; }
    }
}
