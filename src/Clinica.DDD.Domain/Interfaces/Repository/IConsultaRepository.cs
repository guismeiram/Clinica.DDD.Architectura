using Clinica.DDD.Core.DomainObjects;
using Clinica.DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DDD.Domain.Interfaces.Repository
{
    public interface IConsultaRepository
    {
        void Add(Consulta consulta);

        void Delete(Consulta consulta);

        Task<IEnumerable<Consulta>> GetAll();

        Task<Consulta> GetById(int id);

        void Update(Consulta consulta);
    }
}
