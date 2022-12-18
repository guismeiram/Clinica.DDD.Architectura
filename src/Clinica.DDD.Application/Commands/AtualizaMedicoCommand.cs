using Clinica.DDD.Application.Validations;
using Clinica.DDD.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DDD.Application.Commands
{
    public class AtualizaMedicoCommand : Command
    {
       

        //autommaper
        public string Nome { get; set; }
        public string NomeClinica { get; set; }


        public int Crm { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public string Ddd { get; set; }

        public IEnumerable<ConsultaViewModel> Consulta { get; set; }

        public AtualizaMedicoCommand()
        { }

        public override bool EhValido()
        {
            ValidationResult = new AtualizaMedicoValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
