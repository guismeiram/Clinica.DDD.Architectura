﻿using Clinica.DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DDD.Domain.Interfaces.Repository
{
    public interface IConsultaRepository : IRepositoryBase<Consulta>
    {
        Task<IEnumerable<Consulta>> obterConsultaClinicaPaciente();
        Task<Consulta> obterConsultaMedica(String id);
    }
}
