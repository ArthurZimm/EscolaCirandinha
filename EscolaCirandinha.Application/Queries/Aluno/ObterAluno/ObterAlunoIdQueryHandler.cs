using EscolaCirandinha.Application.DTOs;
using EscolaCirandinha.Domain.Contracts.Repositories;
using MediatR;

namespace EscolaCirandinha.Application.Queries.Aluno.ObterAluno
{
    public class ObterAlunoIdQueryHandler : IRequestHandler<ObterAlunoIdQuery, AlunoDto>
    {
        private readonly IAlunoRepository _alunoRepository;

        public ObterAlunoIdQueryHandler(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public async Task<AlunoDto> Handle(ObterAlunoIdQuery request, CancellationToken cancellationToken)
        {
            var aluno = await _alunoRepository.ObtemAlunoId(request.Id);
            return new AlunoDto(aluno!.DadosAluno,aluno.Endereco, aluno.Responsavel, aluno.Turma.Id, aluno.Turma, aluno.AlunoAtividades);
        }
    }
}