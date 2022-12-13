using Clinica.DDD.Architectura.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DDD.Architectura.Service.Validators
{
    public class MedicoValidation : AbstractValidator<Medico>
    {
        public MedicoValidation()
        {
            RuleFor(c => c.Nome)
              .NotEmpty().WithMessage("O campo {PropertyName} precisa de um Nome")
              .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.Idade)
             .NotEmpty().WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.Crm)
             .NotEmpty().WithMessage("O campo {PropertyName} precisa de um Crm")
             .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.NomeClinica)
              .NotEmpty().WithMessage("O campo {PropertyName} precisa de um Nome")
              .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

        }
    }
}
