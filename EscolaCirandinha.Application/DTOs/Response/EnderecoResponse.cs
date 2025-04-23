namespace EscolaCirandinha.Application.DTOs.Response
{
    public sealed record class EnderecoResponse(string Rua, string Numero, string Bairro, string Cidade, string Estado, string Cep);
}