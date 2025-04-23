using EscolaCirandinha.Application.DTOs.Response;
using MediatR;

namespace EscolaCirandinha.Application.Queries.Aluno.ObterAluno
{
    public class ObterAlunoCpfQuery : IRequest<AlunoResponse>
    {
        public ObterAlunoCpfQuery(string cpf)
        {
            Cpf = cpf;
        }

        public string Cpf { get; set; }
    }
}
