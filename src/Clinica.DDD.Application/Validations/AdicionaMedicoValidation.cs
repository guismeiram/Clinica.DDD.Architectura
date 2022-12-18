using Clinica.DDD.Application.Commands;
using Clinica.DDD.Domain.Entities;
using FluentValidation;
using System;

namespace Clinica.DDD.Application.Validations
{
    /// <summary>
    /// Validações ao adicionar o cliente
    /// </summary>
    public class AdicionaMedicoValidation :Validation<AdicionaMedicoCommand> 
    {
        public AdicionaMedicoValidation()
        {
            ValidarId();
            ValidarNome();
            ValidarConsultaDatacadastro();
            ValidarConsultaNome();
            ValidarCrm();
            ValidarIdade();
            ValidarNomeClinica();
            ValidarTelefone();
            
        }
        /*
        public string? MedicoId { get; set; }
        public DateTime Data { get; set; }
        public string? Nome { get; set; }
        // relacionamentos
        public Medico? Medicos { get; set; }         
        */
        protected void ValidarNomeClinica()
        {
            RuleFor(r => r.NomeClinica)
                .NotEmpty().WithMessage("Nome clinica é obrigatório.")
                .Length(2, 200).WithMessage("Nome deve conter no mímimo 2 letras e no máximo 200.");
        }

        protected void ValidarNome()
        {
            RuleFor(r => r.Nome)
                .NotEmpty().WithMessage("Nome é obrigatório.")
                .Length(2, 200).WithMessage("Nome deve conter no mímimo 2 letras e no máximo 200.");
        }

        protected void Validar()
        {
            RuleFor(f => f.Telefone)
                .NotEmpty().WithMessage("Telefone é obrigatório.")
                .Length(2, 200).WithMessage("Nome deve conter no mímimo 2 letras e no máximo 200.");
        }

        protected void ValidarIdade()
        {
            RuleFor(f => f.Idade).NotEmpty().WithMessage("Idade obrigatoria");
        }

        protected void ValidarCrm()
        {
            RuleFor(f => f.Crm).NotEmpty().WithMessage("Idade obrigatoria");
        }

        protected void ValidarTelefone()
        {
            RuleFor(f => f.Telefone).NotEmpty().WithMessage("Telefone obrigatorio");
        }

        protected void ValidarConsultaNome()
        {
            RuleFor(f => f.Consulta.Select(f => f.Nome)).ForEach(p => p.Length(2, 200)).NotEmpty().WithMessage("Nome deve conter no mímimo 2 letras e no máximo 200.");
        }

        protected void ValidarConsultaDatacadastro()
        {
            RuleFor(f => f.Consulta.Select(f => f.Data)).ForEach(p => p.InclusiveBetween(DateTime.MinValue, DateTime.Now.Date)).WithMessage("Data de nascimento é inválida.");
        }
    }
}