using Clinica.DDD.Application.Validations;
using FluentValidation;

namespace Clinica.DDD.Application.Commands
{
    public class RemoveConsultaCommand : Command
    {
        public RemoveConsultaCommand(int id)
        {
            Id = id;
        }
        public override bool EhValido()
        {
            ValidationResult = new RemoveConsultaValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
