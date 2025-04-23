using EscolaCirandinha.Application.DTOs.Response;
using MediatR;

namespace EscolaCirandinha.Application.Queries.Aluno.ObterAluno
{
    public class ObterAlunosTurmaQuery : IRequest<IEnumerable<AlunoResponse>>
    {
        public Guid Id { get; set; }
    }
}