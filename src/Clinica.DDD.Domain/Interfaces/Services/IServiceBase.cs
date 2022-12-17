using Clinica.DDD.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DDD.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> : IDisposable where TEntity : Entity
    {
        Task Adicionar(TEntity entity);
        Task<List<TEntity>> ObterTodos();
        Task<TEntity> ObterPorId(string id);
        Task Atualizar(TEntity entity);
        Task Remover(String id);
        Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);
        Task<int> SaveChanges();
    }
}
