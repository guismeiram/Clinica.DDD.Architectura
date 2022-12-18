using AutoMapper;
using Clinica.DDD.Api.ViewModel;
using Clinica.DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DDD.Mapper.Configuration
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
