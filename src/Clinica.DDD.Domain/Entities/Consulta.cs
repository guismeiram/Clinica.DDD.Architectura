using Clinica.DDD.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DDD.Domain.Entities
{
    public class Consulta : Entity
    {
        public int MedicoId { get; set; }
        public DateTime Data { get; set; }
        public string Nome { get; set; }
        // relacionamentos
        public Medico Medicos { get; set; }

        protected Consulta() { }

        public Consulta(int id, int medicoId, DateTime data, string nome) : base(id)
        {
            Data = data;
            Nome = nome;
        }
        public void AtribuirConsulta(Medico medico) => Medicos = medico;


        public void AtualizarInformacoes(Consulta consulta)
        {
            MedicoId = consulta.MedicoId;
            Data = consulta.Data;
            Nome = consulta.Nome;
            AtribuirConsulta(consulta.Medicos);
        }
    }
}
