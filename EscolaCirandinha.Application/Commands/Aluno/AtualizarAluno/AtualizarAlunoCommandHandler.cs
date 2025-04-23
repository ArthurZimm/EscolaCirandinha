using AutoMapper;
using EscolaCirandinha.Application.DTOs.Response;
using EscolaCirandinha.Domain.Contracts.Repositories;
using MediatR;

namespace EscolaCirandinha.Application.Commands.Aluno.AtualizarAluno
{
    public class AtualizarAlunoCommandHandler : IRequestHandler<AtualizarAlunoCommand, AlunoResponse>
    {
        private readonly IAlunoRepository _alunoRepository;
        private readonly IMapper _mapper;
        public AtualizarAlunoCommandHandler(IAlunoRepository alunoRepository, IMapper mapper)
        {
            _alunoRepository = alunoRepository;
            _mapper = mapper;
        }
        public async Task<AlunoResponse> Handle(AtualizarAlunoCommand request, CancellationToken cancellationToken)
        {
            var aluno = new Domain.Entities.Aluno(request.DadosAluno, request.Endereco, request.Responsavel, request.Senha, Guid.Empty);
            await _alunoRepository.Atualiza(aluno);
            return _mapper.Map<AlunoResponse>(aluno);
        }
    }
}