using Clinica.DDD.Application.Validations;
using FluentValidation;

namespace Clinica.DDD.Application.Commands
{
    public class RemoveMedicoCommand : Command
    {
        public RemoveMedicoCommand(int id)
        {
            Id = id;
        }
        public override bool EhValido()
        {
            ValidationResult = new RemoveMedicoValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
