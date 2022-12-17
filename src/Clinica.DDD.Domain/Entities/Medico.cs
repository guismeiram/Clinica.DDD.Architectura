using Clinica.DDD.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DDD.Domain.Entities
{
    public class Medico : Entity
    {
        //autommaper
        public string? Nome { get; set; }
        public string? NomeClinica { get; set; }



        public string? Crm { get; set; }
        public string? Idade { get; set; }
        public string? Telefone { get; set; }
        public string? Ddd { get; set; }


        // relacionamentos

        public IEnumerable<Consulta>? Consultas { get; set; }


    }
}
