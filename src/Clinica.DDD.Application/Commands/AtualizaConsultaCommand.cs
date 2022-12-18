using Clinica.DDD.Application.Validations;
using Clinica.DDD.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DDD.Application.Commands
{
    public class AtualizaConsultaCommand : Command
    {
        public MedicoViewModel MedicoViewModel { get; set; }
        public DateTime Data { get; set; }
        public string? Nome { get; set; }

        public AtualizaConsultaCommand()
        { }

        public override bool EhValido()
        {
            ValidationResult = new AtualizaConsultaValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
