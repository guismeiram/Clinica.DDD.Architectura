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
    public class ConsultaService : ServiceBase<Consulta>, IConsultaService
    {
        public readonly IConsultaRepository _consultaRepository;
        public ConsultaService(IConsultaRepository consultaRepository) : base(consultaRepository)
        {
            _consultaRepository = consultaRepository;
        }

        public IEnumerable<Consulta> ObterConsultasMedicas(IEnumerable<Consulta> consulta)
        {
            throw new NotImplementedException();
        }
    }
}

