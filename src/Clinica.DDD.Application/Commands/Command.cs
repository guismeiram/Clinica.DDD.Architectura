

using FluentValidation.Results;
using MediatR;
using System.Text.Json.Serialization;

namespace Clinica.DDD.Application.Commands
{
    public abstract class Command : IRequest<ValidationResult>
    {
        public DateTime DataCadastro { get; private set; }
        public int Id { get; set; }

        [JsonIgnore]
        public ValidationResult ValidationResult { get; set; }

        public Command()
        {
            DataCadastro = DateTime.Now.Date;
        }

        public abstract bool EhValido();
    }
}
