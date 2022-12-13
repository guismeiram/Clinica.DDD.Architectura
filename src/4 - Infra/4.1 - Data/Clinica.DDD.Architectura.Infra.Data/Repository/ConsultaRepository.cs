using Clinica.DDD.Architectura.Domain.Entities;
using Clinica.DDD.Architectura.Domain.Interfaces;
using Clinica.DDD.Architectura.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DDD.Architectura.Infra.Data.Repository
{
    public class ConsultaRepository : Repository<Consulta>, IConsultaRepository
    {
        public ConsultaRepository(ClinicaDbContext db) : base(db)
        {
        }

        public async Task<Consulta> obterConsultaMedica(string id)
        {
            return await _db.Consulta.AsNoTracking()
                .Include(c => c.Medicos)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<Consulta>> obterConsultaClinicaPaciente()
        {
            return await _db.Consulta.AsNoTracking().Include(f => f.Medicos)
                .OrderBy(p => p.Nome).ToListAsync();
        }
    }
}
