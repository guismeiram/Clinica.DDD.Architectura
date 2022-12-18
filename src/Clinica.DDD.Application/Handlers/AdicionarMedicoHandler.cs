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
    public class AdicionaMedicoHandler : CommandHandler, IRequestHandler<AdicionaMedicoCommand, ValidationResult>
    {
        private readonly IMedicoRepository _medicoRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AdicionaMedicoHandler(IMedicoRepository medicoRepository, IUnitOfWork unitOfWork)
        {
            _medicoRepository = medicoRepository;
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Criar uma instancia da entidade de cliente
        /// </summary>
        /// <param name="request">requisição contendo os dados do cliente</param>
        /// <returns></returns>
        private Consulta CriarCliente(AdicionaMedicoCommand request)
        {
            var consulta = new Medico(request.Id, request.MedicoId, request.Data, request.Nome);
            consulta.AtribuirConsulta(new (new Random().Next(),
                request.Id,
                request.Medicos?.Nome,
                request.Medicos?.NomeClinica,
                request.Medicos?.Crm,
                request.Medicos?.Idade,
                request.Medicos?.Telefone,
                request.Medicos?.Ddd));

            return consulta;
        }

        public async Task<ValidationResult> Handle(AdicionaMedicoCommand request, CancellationToken cancellationToken)
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