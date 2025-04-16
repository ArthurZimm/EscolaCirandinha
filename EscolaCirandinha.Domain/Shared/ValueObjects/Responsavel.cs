namespace EscolaCirandinha.Domain.Shared.ValueObjects
{
    public sealed record Responsavel(DadosPessoais Mae, DadosPessoais? Pai) : ValueObject;
}