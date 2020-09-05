
using Api.Domain.Dtos.Registro;
using Api.Domain.Dtos.Usuario;

using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {

            #region Usuario
            CreateMap<UsuarioModel, UsuarioDto>()
                .ReverseMap();
            #endregion

            #region Registro
            CreateMap<RegistroModel, RegistroDto>()
                .ReverseMap();
            CreateMap<RegistroModel, RegistroDtoCreate>()
                .ReverseMap();
            CreateMap<RegistroModel, RegistroDtoUpdate>()
                .ReverseMap();
            #endregion

         

        }

    }
}
