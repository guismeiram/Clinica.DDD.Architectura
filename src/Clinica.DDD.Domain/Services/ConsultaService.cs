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

        public async Task<IEnumerable<Consulta>> obterConsultaClinicaPaciente()
        {
            return await _consultaRepository.obterConsultaClinicaPaciente();
        }

        public Task<Consulta> obterConsultaMedica(string id)
        {
            return _consultaRepository.obterConsultaMedica(id);
        }



        /* public bool ClienteEspecial(Cliente cliente)
         {
             return cliente.Ativo && DateTime.Now.Year - cliente.DataCadastro.Year >= 5;
         }*/
    }
}

