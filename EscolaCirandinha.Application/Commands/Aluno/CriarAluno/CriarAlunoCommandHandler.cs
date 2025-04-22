using EscolaCirandinha.Domain.Contracts.Repositories;
using MediatR;

namespace EscolaCirandinha.Application.Commands.Aluno.CriarAluno
{
    public class CriarAlunoCommandHandler : IRequestHandler<CriarAlunoCommand, Guid>
    {
        private readonly IAlunoRepository _alunoRepository;

        public CriarAlunoCommandHandler(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public async Task<Guid> Handle(CriarAlunoCommand request, CancellationToken cancellationToken)
        {
            var aluno = new EscolaCirandinha.Domain.Entities.Aluno(request.DadosAluno, request.Endereco, request.Responsavel, request.Senha, Guid.Empty);
            await _alunoRepository.Adiciona(aluno);
            return aluno.Id;
        }
    }
}