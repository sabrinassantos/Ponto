using System;
using System.Collections.Generic;
using Api.Domain.Dtos.Uf;

namespace Api.Service.Test.Uf
{
    public class UfTestes
    {
        public static string Nome { get; set; }
        public static string Sigla { get; set; }
        public static Guid IdUf { get; set; }

        public List<UsuarioDto> listaUfDto = new List<UsuarioDto>();
        public UsuarioDto ufDto;

        public UfTestes()
        {
            IdUf = Guid.NewGuid();
            Sigla = Faker.Address.UsState().Substring(1, 3);
            Nome = Faker.Address.UsState();

            for (int i = 0; i < 10; i++)
            {
                var dto = new UsuarioDto()
                {
                    Id = Guid.NewGuid(),
                    Sigla = Faker.Address.UsState().Substring(1, 3),
                    Nome = Faker.Address.UsState()
                };
                listaUfDto.Add(dto);
            };

            ufDto = new UsuarioDto
            {
                Id = IdUf,
                Sigla = Sigla,
                Nome = Nome
            };
        }

    }
}
