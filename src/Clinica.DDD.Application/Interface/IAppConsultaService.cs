using Clinica.DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DDD.Application.Interface
{
    public interface IAppConsultaService : IAppServiceBase<Consulta>
    {
        Task<IEnumerable<Consulta>> obterConsultaClinicaPaciente();
        Task<Consulta> obterConsultaMedica(String id);
    }
}
