using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Clinica.DDD.Application.Interface;
using Clinica.DDD.Api.ViewModel;
using Clinica.DDD.Domain.Interfaces.Repository;
using AutoMapper;
using Clinica.DDD.Domain.Entities;

namespace Clinica.DDD.Api.V1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaController : ControllerBase
    {
        private readonly IAppConsultaService _consultaApp;
        private readonly IMapper _mapper;

        public ConsultaController(IAppConsultaService consultaApp, IMapper mapper)
        {
            _consultaApp = consultaApp;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ConsultaViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<Consulta>, IEnumerable<ConsultaViewModel>>(await _consultaApp.obterConsultaClinicaPaciente());

            // return _mapper.Map<IEnumerable<ConsultaViewModel>>(await _consultaRepository.obterConsultaClinicaPaciente());
        }
        //get
    }
}
