using Clinica.DDD.Core.DomainObjects;
using Clinica.DDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DDD.Application.Services
{
    public class AppServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : Entity, new()
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }
        public async Task Adicionar(TEntity entity)
        {
           await _serviceBase.Adicionar(entity);
        }

        public async Task Atualizar(TEntity entity)
        {
            await _serviceBase.Atualizar(entity);
        }

        public async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
           return  await _serviceBase.Buscar(predicate);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }

        public async Task<TEntity> ObterPorId(string id)
        {
           return  await _serviceBase.ObterPorId(id);
        }

        public async Task<List<TEntity>> ObterTodos()
        {
            return await _serviceBase.ObterTodos();
        }

        public async Task Remover(string id)
        {
            await _serviceBase.Remover(id);
        }

        public async Task<int> SaveChanges()
        {
            return await _serviceBase.SaveChanges();
        }
    }
}
