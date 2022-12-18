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
    public class MedicoRepository : IMedicoRepository
    {
        private readonly ClinicaDbContext _context;

        public MedicoRepository(ClinicaDbContext context)
        {
            _context = context;
        }
        public void Add(Medico medico) => _context.Add(medico);


        public void Delete(Medico medico) => _context.Remove(medico);

        public async Task<IEnumerable<Medico>> GetAll() => await _context.Medico
                             .Include(i => i.Consultas)
                             .OrderBy(o => o.Nome)
                             .AsNoTracking()
                             .ToListAsync();

        public async Task<Medico> GetById(int id)
              => await _context.Medico
                             .Include(i => i.Consultas)
                             .AsNoTracking()
                             .FirstOrDefaultAsync(f => f.Id == id);
        public void Update(Medico entity)
                        => _context.Update(entity);
    }
}
