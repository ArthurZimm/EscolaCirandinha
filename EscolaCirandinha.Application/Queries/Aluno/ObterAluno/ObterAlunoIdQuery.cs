using EscolaCirandinha.Application.DTOs;
using MediatR;

namespace EscolaCirandinha.Application.Queries.Aluno.ObterAluno
{
    public class ObterAlunoIdQuery : IRequest<AlunoDto>
    {
        public Guid Id { get; set; }
        public ObterAlunoIdQuery(Guid id)
        {
            Id = id;
        }
    }
}