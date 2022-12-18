using Clinica.DDD.Application.Commands;
using FluentValidation;
using System;

namespace Clinica.DDD.Application.Validations
{
    /// <summary>
    /// Validações ao adicionar o cliente
    /// </summary>
    public class AdicionaConsultaValidation :Validation<AdicionaConsultaCommand> 
    {
        public AdicionaConsultaValidation()
        {
            ValidarId();
            ValidarNome();
            ValidarMedicoNomeClinica();
            ValidarMedicoCrm();
            ValidarData();
            ValidarDatacadastro();
            ValidarMedicoNome();
            ValidarMedicoDdd();
            ValidarDatacadastro();
        }
        /*
        public string? MedicoId { get; set; }
        public DateTime Data { get; set; }
        public string? Nome { get; set; }
        // relacionamentos
        public Medico? Medicos { get; set; }         
        */
        protected void ValidarData()
        {
            RuleFor(r => r.Data)
              .InclusiveBetween(DateTime.MinValue, DateTime.MaxValue)
              .WithMessage("Data da consulta");
        }

        protected void ValidarNome()
        {
            RuleFor(r => r.Nome)
                .NotEmpty().WithMessage("Nome é obrigatório.")
                .Length(2, 200).WithMessage("Nome deve conter no mímimo 2 letras e no máximo 200.");
        }

        protected void ValidarMedicoCrm()
        {
            RuleFor(f => f.Medicos.Crm).NotEmpty().WithMessage("CRM obrigatorio");
        }

        protected void ValidarMedicoDdd()
        {
            RuleFor(f => f.Medicos.Ddd).NotEmpty().WithMessage("DDD obrigatorio");
        }

        protected void ValidarMedicoIdade()
        {
            RuleFor(f => f.Medicos.Idade).NotEmpty().WithMessage("Idade obrigatoria");
        }

        protected void ValidarMedicoNomeClinica()
        {
            RuleFor(f => f.Medicos.NomeClinica).NotEmpty().WithMessage("Nome da Clinica obrigatorio");
        }

        protected void ValidarMedicoNome()
        {
            RuleFor(f => f.Medicos.Nome).NotEmpty().WithMessage("Nome do Medico Obrigatorio");
        }

        protected void ValidarDatacadastro()
        {
            RuleFor(f => f.DataCadastro).InclusiveBetween(DateTime.MinValue, DateTime.Now.Date)
              .WithMessage("Data de nascimento é inválida.");
        }
    }
}