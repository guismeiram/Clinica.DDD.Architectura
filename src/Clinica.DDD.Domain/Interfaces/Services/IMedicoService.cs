using Clinica.DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DDD.Domain.Interfaces.Services
{
    public interface IMedicoService : IServiceBase<Medico>
    {
        IEnumerable<Medico> BuscarPorNome(string nome);
    }
}
