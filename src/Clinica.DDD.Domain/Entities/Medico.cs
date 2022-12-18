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



        public int? Crm { get; set; }
        public int? Idade { get; set; }
        public string? Telefone { get; set; }
        public string? Ddd { get; set; }


        // relacionamentos

        public IEnumerable<Consulta> Consultas { get; set; }

        protected Medico() { }

        public Medico(int id, string? nome, string? nomeClinica, int? crm,
            int? idade, string? telefone, string? ddd) : base(id)
        {
            
            Nome = nome;
            NomeClinica = nomeClinica;
            Crm = crm;
            Idade = idade;
            Telefone = telefone;
            Ddd = ddd;
        }

        public void AtribuirMedico(IEnumerable<Consulta> consulta) => Consultas = consulta;


        public void AtualizarInformacoes(Medico medico)
        {
            Nome = medico.Nome;
            NomeClinica = medico.NomeClinica;
            Crm = medico.Crm;
            Idade = medico.Idade;
            Telefone = medico.Telefone;
            Ddd = medico.Ddd;
        }
    }
}
