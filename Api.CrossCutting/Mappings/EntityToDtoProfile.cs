using Api.Domain.Dtos.Registro;
using Api.Domain.Dtos.Usuario;

using Api.Domain.Entities;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {

            CreateMap<UsuarioDto, UsuarioEntity>()
               .ReverseMap();

            CreateMap<RegistroDto, RegistroEntity>()
               .ReverseMap();

            CreateMap<RegistroDtoCompleto, RegistroEntity>()
               .ReverseMap();

            CreateMap<RegistroDtoCreateResult, RegistroEntity>()
               .ReverseMap();

            CreateMap<RegistroDtoUpdateResult, RegistroEntity>()
               .ReverseMap();

            

        }
    }
}
