using EscolaCirandinha.Application.DTOs.Response;
using EscolaCirandinha.Domain.Shared.ValueObjects;
using MediatR;

namespace EscolaCirandinha.Application.Commands.Aluno.RemoverAluno
{
    public class RemoveAlunoCommand : IRequest<AlunoResponse>
    {
        public DadosPessoais DadosAluno { get; set; }
        public Endereco Endereco { get; set; }
        public Responsavel Responsavel { get; set; }
        public string Senha { get; set; }
    }
}
