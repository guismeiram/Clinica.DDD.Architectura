using AutoMapper;
using Clinica.DDD.Api.ViewModel;
using Clinica.DDD.Domain.Entities;

namespace Clinica.DDD.Api.AutoMapper
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
