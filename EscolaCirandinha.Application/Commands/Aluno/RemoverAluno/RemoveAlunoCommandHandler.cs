using AutoMapper;
using EscolaCirandinha.Application.DTOs.Response;
using EscolaCirandinha.Domain.Contracts.Repositories;
using MediatR;

namespace EscolaCirandinha.Application.Commands.Aluno.RemoverAluno
{
    public class RemoveAlunoCommandHandler : IRequestHandler<RemoveAlunoCommand, AlunoResponse>
    {
        private readonly IAlunoRepository _alunoRepository;
        private readonly IMapper _mapper;
        public RemoveAlunoCommandHandler(IAlunoRepository alunoRepository, IMapper mapper)
        {
            _alunoRepository = alunoRepository;
            _mapper = mapper;
        }
        public async Task<AlunoResponse> Handle(RemoveAlunoCommand request, CancellationToken cancellationToken)
        {
            var aluno = await _alunoRepository.ObtemAlunoCpf(request.DadosAluno.Cpf) ?? throw new Exception("Aluno não encontrado.");
            await _alunoRepository.Remover(aluno);
            return _mapper.Map<AlunoResponse>(aluno);
        }
    }
}