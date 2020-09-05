using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Registro;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.Registro;
using Api.Domain.Models;
using Api.Domain.Repository;
using AutoMapper;

namespace Api.Service.Services
{
    public class RegistroService : IRegistroService
    {
        private IRegistroRepository _repository;
        private readonly IMapper _mapper;

        public RegistroService(IRegistroRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<RegistroDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<RegistroDto>(entity);
        }

        public async Task<RegistroDtoCompleto> GetCompleteByUsuario(Guid id)
        {
            var entity = await _repository.GetCompleteByUsuario(id);
            return _mapper.Map<RegistroDtoCompleto>(entity);
        }

        public async Task<IEnumerable<RegistroDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<RegistroDto>>(listEntity);
        }

        public async Task<RegistroDtoCreateResult> Post(RegistroDtoCreate registro)
        {
            var model = _mapper.Map<RegistroModel>(registro);
            var entity = _mapper.Map<RegistroEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<RegistroDtoCreateResult>(result);
        }

        public async Task<RegistroDtoUpdateResult> Put(RegistroDtoUpdate registro)
        {
            var model = _mapper.Map<RegistroModel>(registro);
            var entity = _mapper.Map<RegistroEntity>(model);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<RegistroDtoUpdateResult>(result);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
