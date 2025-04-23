namespace EscolaCirandinha.Application.DTOs.Response
{
    public sealed record class AtividadeResponse(Guid Id, TurmaResponse Turma, string Avaliacao, decimal NotaMaxima);
}