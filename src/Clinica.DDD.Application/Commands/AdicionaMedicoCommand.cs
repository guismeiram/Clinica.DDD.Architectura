using Clinica.DDD.Application.Validations;
using Clinica.DDD.Application.ViewModel;
using System;

namespace Clinica.DDD.Application.Commands
{
    /// <summary>
    /// Comando para adicionar um cliente
    /// </summary>
    public class AdicionaMedicoCommand : Command
    {
        public int Id { get; set; }

        //autommaper
        public string Nome { get; set; }
        public string NomeClinica { get; set; }


        public int Crm { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public string Ddd { get; set; }

        public IEnumerable<ConsultaViewModel> Consulta { get; set; }

        public AdicionaMedicoCommand()
        {
            Id = new Random().Next();
        }

        public override bool EhValido()
        {
            ValidationResult = new AdicionaMedicoValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}