namespace EscolaCirandinha.Application.DTOs.Response
{
    public sealed record class TurmaResponse(Guid Id,string Nome, ProfessorResponse Professor);
}