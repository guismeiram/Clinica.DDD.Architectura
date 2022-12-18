using Clinica.DDD.Application.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DDD.Application.Validations
{
    public abstract class Validation<T> : AbstractValidator<T>
         where T : Command
    {
        protected void ValidarId()
        {
            RuleFor(r => r.Id)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Identificador inválido.");
        }
    }
}
