using EscolaCirandinha.Domain.Shared.ValueObjects;
using MediatR;

namespace EscolaCirandinha.Application.Commands.Aluno.CriarAluno
{
    public class CriarAlunoCommand : IRequest<Guid>
    {
        public DadosPessoais DadosAluno { get; set; }
        public Endereco Endereco { get; set; }
        public Responsavel Responsavel { get; set; }
        public string Senha { get; set; }
    }
}