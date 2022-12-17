using Clinica.DDD.Domain.Entities;
using Clinica.DDD.Domain.Interfaces.Repository;
using Clinica.DDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DDD.Domain.Services
{
    public class MedicoService : ServiceBase<Medico>, IMedicoService
    {
        private readonly IMedicoRepository _medicoRepository;

        public MedicoService(IMedicoRepository medicoRepository) : base(medicoRepository)
        {
            _medicoRepository = medicoRepository;
        }

        public IEnumerable<Medico> BuscarPorNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
