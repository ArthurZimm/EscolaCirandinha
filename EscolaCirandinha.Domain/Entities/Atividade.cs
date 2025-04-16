using EscolaCirandinha.Domain.Shared.Entities;

namespace EscolaCirandinha.Domain.Entities
{
    public sealed class Atividade : Entity
    {
        #region Propriedades
        public Turma Turma { get; }
        public string Avaliacao { get; set; }
        #endregion
        #region Construtores
        public Atividade(Turma turma, string avaliacao) : base(Guid.NewGuid())
        {
            Turma = turma;
            Avaliacao = avaliacao;
        }
        #endregion
    }
}