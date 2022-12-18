using Clinica.DDD.Application.Commands;
using Clinica.DDD.Application.Handlers;
using Clinica.DDD.Domain.Entities;
using Clinica.DDD.Domain.Interfaces.Repository;
using Clinica.DDD.Domain.UnitOfWork;
using FluentValidation.Results;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SevenTech.Application.Handlers
{
    /// <summary>
    /// Manipulador do comando de adicionar cliente
    /// </summary>
    public class AdicionaConsultaHandler : CommandHandler, IRequestHandler<AdicionaConsultaCommand, ValidationResult>
    {
        private readonly IConsultaRepository _consultaRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AdicionaConsultaHandler(IConsultaRepository consultaRepository, IUnitOfWork unitOfWork)
        {
            _consultaRepository = consultaRepository;
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Criar uma instancia da entidade de cliente
        /// </summary>
        /// <param name="request">requisição contendo os dados do cliente</param>
        /// <returns></returns>
        private Consulta CriarCliente(AdicionaConsultaCommand request)
        {
            var consulta = new Consulta(request.Id, request.MedicoId, request.Data, request.Nome);
            consulta.AtribuirConsulta(new Medico(
                request.Id,
                request.Medicos?.Nome,
                request.Medicos?.NomeClinica,
                request.Medicos?.Crm,
                request.Medicos?.Idade,
                request.Medicos?.Telefone,
                request.Medicos?.Ddd));

                

            return consulta;
        }

        public async Task<ValidationResult> Handle(AdicionaConsultaCommand request, CancellationToken cancellationToken)
        {
            if (!request.EhValido())
                return request.ValidationResult;

            var clienteResult = await _consultaRepository.GetById(request.Id);

            if (clienteResult != null)
            {
                AdicionarErro("Cliente já cadastrado.");
                return ValidationResult;
            }

            _consultaRepository.Add(CriarCliente(request));

            return await PersistirDados(_unitOfWork);
        }

        
    }
}