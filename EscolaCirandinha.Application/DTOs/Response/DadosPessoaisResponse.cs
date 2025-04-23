namespace EscolaCirandinha.Application.DTOs.Response
{
    public sealed record class DadosPessoaisResponse(string Nome, string Cpf, DateTime DataNascimento);
}