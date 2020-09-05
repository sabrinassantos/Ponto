using System;
using System.Collections.Generic;
using Api.Domain.Dtos.Registro;
using Api.Domain.Dtos.Uf;

namespace Api.Service.Test.Municipio
{
    public class MunicipioTestes
    {
        public static string NomeMunicipio { get; set; }
        public static int CodigoIBGEMunicipio { get; set; }
        public static string NomeMunicipioAlterado { get; set; }
        public static int CodigoIBGEMunicipioAlterado { get; set; }
        public static Guid IdMunicipio { get; set; }
        public static Guid IdUf { get; set; }

        public List<RegistroDto> listaDto = new List<RegistroDto>();
        public RegistroDto municipioDto;
        public RegistroDtoCompleto municipioDtoCompleto;
        public RegistroDtoCreate municipioDtoCreate;
        public RegistroDtoCreateResult municipioDtoCreateResult;
        public RegistroDtoUpdate municipioDtoUpdate;
        public RegistroDtoUpdateResult municipioDtoUpdateResult;

        //public MunicipioTestes()
        //{
        //    IdMunicipio = Guid.NewGuid();
        //    NomeMunicipio = Faker.Address.StreetName();
        //    CodigoIBGEMunicipio = Faker.RandomNumber.Next(1, 10000);
        //    NomeMunicipioAlterado = Faker.Address.StreetName();
        //    CodigoIBGEMunicipioAlterado = Faker.RandomNumber.Next(1, 10000);
        //    IdUf = Guid.NewGuid();

        //    for (int i = 0; i < 10; i++)
        //    {
        //        var dto = new RegistroDto()
        //        {
        //            Id = Guid.NewGuid(),
        //            Nome = Faker.Name.FullName(),
        //            CodIBGE = Faker.RandomNumber.Next(1, 10000),
        //            UfId = Guid.NewGuid()
        //        };
        //        listaDto.Add(dto);
        //    }

        //    municipioDto = new RegistroDto
        //    {
        //        Id = IdMunicipio,
        //        Nome = NomeMunicipio,
        //        CodIBGE = CodigoIBGEMunicipio,
        //        UfId = IdUf
        //    };

        //    municipioDtoCompleto = new RegistroDtoCompleto
        //    {
        //        Id = IdMunicipio,
        //        Nome = NomeMunicipio,
        //        CodIBGE = CodigoIBGEMunicipio,
        //        UfId = IdUf,
        //        Uf = new UsuarioDto
        //        {
        //            Id = Guid.NewGuid(),
        //            Nome = Faker.Address.UsState(),
        //            Sigla = Faker.Address.UsState().Substring(1, 3)
        //        }
        //    };

        //    municipioDtoCreate = new RegistroDtoCreate
        //    {
        //        Nome = NomeMunicipio,
        //        CodIBGE = CodigoIBGEMunicipio,
        //        UfId = IdUf
        //    };

        //    municipioDtoCreateResult = new RegistroDtoCreateResult
        //    {
        //        Id = IdMunicipio,
        //        Nome = NomeMunicipio,
        //        CodIBGE = CodigoIBGEMunicipio,
        //        UfId = IdUf,
        //        CreateAt = DateTime.UtcNow
        //    };

        //    municipioDtoUpdate = new RegistroDtoUpdate
        //    {
        //        Id = IdMunicipio,
        //        Nome = NomeMunicipioAlterado,
        //        CodIBGE = CodigoIBGEMunicipioAlterado,
        //        UfId = IdUf
        //    };

        //    municipioDtoUpdateResult = new RegistroDtoUpdateResult
        //    {
        //        Id = IdMunicipio,
        //        Nome = NomeMunicipioAlterado,
        //        CodIBGE = CodigoIBGEMunicipioAlterado,
        //        UfId = IdUf,
        //        UpdateAt = DateTime.UtcNow
        //    };

        //}
    }
}
