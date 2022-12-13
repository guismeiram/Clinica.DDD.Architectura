using Clinica.DDD.Architectura.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DDD.Architectura.Domain.Interfaces
{
    public interface IConsultaRepository : IRepository<Consulta>
    {
        Task<IEnumerable<Consulta>> obterConsultaClinicaPaciente();
        Task<Consulta> obterConsultaMedica(String id);

    }
}
