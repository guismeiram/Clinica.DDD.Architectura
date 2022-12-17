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
        IEnumerable<Consulta> BuscarPorNome(string nome);

    }
}
