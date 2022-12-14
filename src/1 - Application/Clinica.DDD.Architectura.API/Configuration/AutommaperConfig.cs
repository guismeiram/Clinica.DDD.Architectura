using AutoMapper;
using Clinica.DDD.Architectura.API.ViewModels;
using Clinica.DDD.Architectura.Domain.Entities;

namespace Clinica.DDD.Architectura.API.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<MedicoViewModel, Medico>().ReverseMap();
            CreateMap<ConsultaViewModel, Consulta>();

            //one to many
            CreateMap<Consulta, ConsultaViewModel>()
                .ForMember(x => x.Nome, opt => opt.MapFrom(src => src.Medicos.Nome));



        }
    }
}
