using Clinica.DDD.Application.Validations;
using Clinica.DDD.Application.ViewModel;
using System;

namespace Clinica.DDD.Application.Commands
{
    /// <summary>
    /// Comando para adicionar um cliente
    /// </summary>
    public class AdicionaConsultaCommand : Command
    {
        public int Id { get; set; }
        public int MedicoId { get; set; }
        public DateTime Data { get; set; }
        public string Nome { get; set; }
        public MedicoViewModel Medicos { get; set; }

        public AdicionaConsultaCommand()
        {
            Id = new Random().Next();
        }

        public override bool EhValido()
        {
            ValidationResult = new AdicionaConsultaValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}