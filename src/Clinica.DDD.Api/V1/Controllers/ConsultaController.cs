using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
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
        private readonly IMapper _mapper;

        public ConsultaController( IMapper mapper)
        {
            _mapper = mapper;
        }

       /* [HttpGet]
        public async Task<IEnumerable<ConsultaViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<Consulta>, IEnumerable<ConsultaViewModel>>(await _consultaApp.obterConsultaClinicaPaciente());

            // return _mapper.Map<IEnumerable<ConsultaViewModel>>(await _consultaRepository.obterConsultaClinicaPaciente());
        }
        //get

        [HttpPost]
        public async Task<ActionResult<ConsultaViewModel>> Adicionar(ConsultaViewModel consultaViewModel)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _consultaService.Adicionar(_mapper.Map<Consulta>(consultaViewModel));

            return CustomResponse(consultaViewModel);
        }*/
    }
}
