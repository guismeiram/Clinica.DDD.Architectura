using Clinica.DDD.Application.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DDD.Application.Validations
{
    public class AtualizaConsultaValidation : Validation<AtualizaConsultaCommand>
    {
        
            public AtualizaConsultaValidation()
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
                RuleFor(f => f.MedicoViewModel.Crm).NotEmpty().WithMessage("CRM obrigatorio");
            }

            protected void ValidarMedicoDdd()
            {
                RuleFor(f => f.MedicoViewModel.Ddd).NotEmpty().WithMessage("DDD obrigatorio");
            }

            protected void ValidarMedicoIdade()
            {
                RuleFor(f => f.MedicoViewModel.Idade).NotEmpty().WithMessage("Idade obrigatoria");
            }

            protected void ValidarMedicoNomeClinica()
            {
                RuleFor(f => f.MedicoViewModel.NomeClinica).NotEmpty().WithMessage("Nome da Clinica obrigatorio");
            }

            protected void ValidarMedicoNome()
            {
                RuleFor(f => f.MedicoViewModel.Nome).NotEmpty().WithMessage("Nome do Medico Obrigatorio");
            }

            protected void ValidarDatacadastro()
            {
                RuleFor(f => f.DataCadastro).InclusiveBetween(DateTime.MinValue, DateTime.Now.Date)
                  .WithMessage("Data de nascimento é inválida.");
            }
        
    }

}
