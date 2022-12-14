using AutoMapper;
using Clinica.DDD.Architectura.Domain.Entities;
using Clinica.DDD.Architectura.Domain.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DDD.Architectura.Service.Services
{
    public class ConsultaService<TEntity> : IConsultaService<TEntity> where TEntity : Entity
    {
        private readonly IRepository<TEntity> _repository;
        private readonly IMapper _mapper;

        public ConsultaService(IRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public TOutputModel Add<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TValidator : AbstractValidator<TEntity>
            where TInputModel : class
            where TOutputModel : class
        {
            TEntity entity = _mapper.Map<TEntity>(inputModel);

            Validate(entity, Activator.CreateInstance<TValidator>());
            _repository.Insert(entity);

            TOutputModel outputModel = _mapper.Map<TOutputModel>(entity);

            return outputModel;
        }

        public void Delete(string id) => _repository.Delete(id);

        public IEnumerable<TOutputModel> Get<TOutputModel>() where TOutputModel : class
        {
            var entities = _repository.Select();

            var outputModels = entities.Select(s => _mapper.Map<TOutputModel>(s));

            return outputModels;
        }

        public TOutputModel GetById<TOutputModel>(string id) where TOutputModel : class
        {
            var entity = _repository.Select(id);

            var outputModel = _mapper.Map<TOutputModel>(entity);

            return outputModel;
        }

        public TOutputModel Update<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TValidator : AbstractValidator<TEntity>
            where TInputModel : class
            where TOutputModel : class
        {
            TEntity entity = _mapper.Map<TEntity>(inputModel);

            Validate(entity, Activator.CreateInstance<TValidator>());
            _repository.Update(entity);

            TOutputModel outputModel = _mapper.Map<TOutputModel>(entity);

            return outputModel;
        }

        private void Validate(TEntity obj, AbstractValidator<TEntity> validator)
        {
            if (obj == null)
                throw new Exception("Registros não detectados!");

            validator.ValidateAndThrow(obj);
        }
    }
}
