using Clinica.DDD.Domain.UnitOfWork;
using Clinica.DDD.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DDD.Infra.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private ClinicaDbContext _context;

        public UnitOfWork(ClinicaDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Commit()
            => await _context.SaveChangesAsync() > 0;
    }
}
