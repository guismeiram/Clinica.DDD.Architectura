using Clinica.DDD.Domain.Entities;
using Clinica.DDD.Domain.Interfaces.Repository;
using Clinica.DDD.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DDD.Infra.Repositories
{
    internal class ConsultaRepository : RepositoryBase<Consulta>, IConsultaRepository
    {
        protected ConsultaRepository(ClinicaDbContext db) : base(db)
        {
        }

        

        public async Task<Consulta> obterConsultaMedica(string id)
        {
            return await Db.Consulta.AsNoTracking()
                .Include(c => c.Medicos)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<Consulta>> obterConsultaClinicaPaciente()
        {
            return await Db.Consulta.AsNoTracking().Include(f => f.Medicos)
                .OrderBy(p => p.Nome).ToListAsync();
        }
    }
}
