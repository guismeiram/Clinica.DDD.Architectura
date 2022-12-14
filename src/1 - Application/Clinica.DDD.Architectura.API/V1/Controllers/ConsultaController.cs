using AutoMapper;
using Clinica.DDD.Architectura.API.ViewModels;
using Clinica.DDD.Architectura.Domain.Entities;
using Clinica.DDD.Architectura.Domain.Interfaces;
using Clinica.DDD.Architectura.Service.Validators;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Clinica.DDD.Architectura.API.V1.Controllers
{
    public class ConsultaController : ControllerBase
    {
        private readonly IConsultaRepository _consultaRepository;
        private readonly IConsultaService<Consulta> _consultaService;
        private readonly IMapper _mapper;

        public ConsultaController(IMapper mapper,
                                  IConsultaRepository consultaRepository,
                                  IConsultaService<Consulta> consultaService)
        {
            _mapper = mapper;
            _consultaRepository = consultaRepository;
            _consultaService = consultaService;
        }

        [HttpGet]
        public async Task<IEnumerable<ConsultaViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<ConsultaViewModel>>(await _consultaRepository.obterConsultaClinicaPaciente());
        }



        [HttpPost]
        public IActionResult Adicionar([FromBody] CreateConsultaViewModel consulta)
        {
            if (consulta == null)
                return NotFound();

            return Execute(() => _consultaService.Add<CreateConsultaViewModel, ConsultaViewModel, ConsultaValidation>(consulta));

        }

        [HttpPut]
        public IActionResult Update([FromBody] UpdateConsultaViewModel consulta)
        {
            if (consulta == null)
                return NotFound();

            return Execute(() => _consultaService.Update<UpdateConsultaViewModel, ConsultaViewModel, ConsultaValidation>(consulta));
        }


        [HttpGet]
        [Route("ObterConsultaPorId", Name = "ObterConsultaPorId")]
        public async Task<ActionResult<ConsultaViewModel>> ObterConsultaPorId(string id)
        {
            ConsultaViewModel consulta = await ObterConsultaMedica(id);

            if (consulta == null) return NotFound();
            if (id == null) return NotFound();

            return Ok(consulta);
        }

        private async Task<ConsultaViewModel> ObterConsultaMedica(string id)
        {
            return _mapper.Map<ConsultaViewModel>(await _consultaRepository.obterConsultaMedica(id));
        }

        [HttpDelete("{Guid:id}")]
        public async Task<ActionResult<ConsultaViewModel>> Delete(string id)
        {
            ConsultaViewModel consulta = await ObterConsultaMedica(id);

            if (consulta == null) return NotFound();
            if (id == null) return NotFound();
            Execute(() =>
            {
                _consultaService.Delete(id);
                return true;
            });

            return consulta;
        }

        private IActionResult Execute(Func<object> func)
        {
            try
            {
                var result = func();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }

}
