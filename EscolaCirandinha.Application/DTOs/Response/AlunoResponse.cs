namespace EscolaCirandinha.Application.DTOs.Response
{
    public sealed record class AlunoResponse(
        Guid Id,
        DadosPessoaisResponse DadosPessoaisAluno,
        EnderecoResponse EnderecoAluno,
        TurmaResponse TurmaResponse
    );
}