using Clinica.DDD.Application.Interface;
using Clinica.DDD.Domain.Entities;
using Clinica.DDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DDD.Application.Services
{
    public class AppConsultaService : AppServiceBase<Consulta>, IAppConsultaService
    {
        private readonly IConsultaService _consultaService;
        public AppConsultaService(IConsultaService consultaService) : base(consultaService)
        {
            _consultaService = consultaService;
        }

        public async Task<IEnumerable<Consulta>> obterConsultaClinicaPaciente()
        {
            return await _consultaService.obterConsultaClinicaPaciente();
        }

        public Task<Consulta> obterConsultaMedica(string id)
        {
            return _consultaService.obterConsultaMedica(id);
        }

       
    }
}
