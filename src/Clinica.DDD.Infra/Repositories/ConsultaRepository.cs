using Clinica.DDD.Core.DomainObjects;
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
    public class ConsultaRepository : IConsultaRepository
    {
        private readonly ClinicaDbContext _context;

        public ConsultaRepository(ClinicaDbContext context)
        {
            _context = context;
        }
        public void Add(Consulta consulta) => _context.Add(consulta);


        public void Delete(Consulta consulta) => _context.Remove(consulta);

        public async Task<IEnumerable<Consulta>> GetAll() => await _context.Consulta
                             .Include(i => i.Medicos)
                             .OrderBy(o => o.Nome)
                             .AsNoTracking()
                             .ToListAsync();

        public async Task<Consulta> GetById(int id)
              => await _context.Consulta
                             .Include(i => i.Medicos)
                             .AsNoTracking()
                             .FirstOrDefaultAsync(f => f.Id == id);
        public void Update(Consulta entity)
                        => _context.Update(entity);
    }
}
