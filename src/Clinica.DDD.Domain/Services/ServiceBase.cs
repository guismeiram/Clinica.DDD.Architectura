using Clinica.DDD.Core.DomainObjects;
using Clinica.DDD.Domain.Interfaces.Repository;
using Clinica.DDD.Domain.Interfaces.Services;

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Clinica.DDD.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : Entity, new()
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public async Task Adicionar(TEntity entity)
        {
            await _repository.Adicionar(entity);
        }

        public async Task Atualizar(TEntity entity)
        {
            await _repository.Atualizar(entity);
        }

        public async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return await _repository.Buscar(predicate);
                //            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();

        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public Task<TEntity> ObterPorId(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TEntity>> ObterTodos() => await _repository.ObterTodos();

        public async Task Remover(string id)
        {
            await _repository.Remover(id);
        }

        public async Task<int> SaveChanges() => await _repository.SaveChanges();
    }
}
