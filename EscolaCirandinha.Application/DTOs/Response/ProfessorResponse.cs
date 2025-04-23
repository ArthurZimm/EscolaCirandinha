using EscolaCirandinha.Domain.Shared.ValueObjects;

namespace EscolaCirandinha.Application.DTOs.Response
{
    public sealed record class ProfessorResponse(Guid Id, DadosPessoaisResponse DadosPessoaisProfessor, ICollection<TurmaResponse>Turmas);
}