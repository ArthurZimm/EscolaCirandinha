namespace EscolaCirandinha.Domain.Shared.ValueObjects
{
    public sealed record Responsavel(DadosPessoais Mae, DadosPessoais? Pai) : ValueObject
    {
        public DadosPessoais Mae { get; private set; } = Mae;
        public DadosPessoais? Pai { get; private set; } = Pai;
        private Responsavel() : this(default!, null) { }
    }
}