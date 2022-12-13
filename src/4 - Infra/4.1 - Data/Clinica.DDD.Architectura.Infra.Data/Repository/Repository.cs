using Clinica.DDD.Architectura.Domain.Entities;
using Clinica.DDD.Architectura.Domain.Interfaces;
using Clinica.DDD.Architectura.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DDD.Architectura.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly ClinicaDbContext _db;

        public Repository(ClinicaDbContext db)
        {
            _db = db;
        }

        public void Insert(TEntity obj)
        {
            _db.Set<TEntity>().Add(obj);
            _db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _db.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            _db.Set<TEntity>().Remove(Select(id));
            _db.SaveChanges();
        }

        public IList<TEntity> Select() =>
            _db.Set<TEntity>().ToList();

        public TEntity Select(int id) =>
            _db.Set<TEntity>().Find(id);

    }
}
