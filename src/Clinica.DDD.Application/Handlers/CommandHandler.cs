using Clinica.DDD.Domain.UnitOfWork;
using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace Clinica.DDD.Application.Handlers
{
    public abstract class CommandHandler
    {
        protected ValidationResult ValidationResult;

        protected CommandHandler()
        {
            ValidationResult = new ValidationResult();
        }

        protected void AdicionarErro(string mensagem)
            => ValidationResult.Errors.Add(new ValidationFailure(string.Empty, mensagem));

        protected async Task<ValidationResult> PersistirDados(IUnitOfWork unitOfWork)
        {
            if (!await unitOfWork.Commit()) AdicionarErro("Houve um erro ao persistir os dados.");

            return ValidationResult;
        }
    }
}
