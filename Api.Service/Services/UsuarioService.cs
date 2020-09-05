using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Usuario;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.Usuario;
using Api.Domain.Models;
using Api.Domain.Repository;
using AutoMapper;

namespace Api.Service.Services
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository _repository;
        private readonly IMapper _mapper;

        public UsuarioService(IUsuarioRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<UsuarioDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<UsuarioDto>(entity);
        }

        public async Task<IEnumerable<UsuarioDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<UsuarioDto>>(listEntity);
        }

        public async Task<UsuarioDtoCreateResult> Post(UsuarioDtoCreate user)
        {
            var model = _mapper.Map<UsuarioModel>(user);
            var entity = _mapper.Map<UsuarioEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<UsuarioDtoCreateResult>(result);
        }
    }
}
