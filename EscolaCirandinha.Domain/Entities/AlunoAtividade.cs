using EscolaCirandinha.Domain.Shared.Entities;

namespace EscolaCirandinha.Domain.Entities
{
    public sealed class AlunoAtividade : Entity
    {
        #region Propriedades
        public Guid AlunoId { get; private set; }
        public Guid AtividadeId { get; private set; }
        public decimal Nota { get; private set; }
        #endregion

        #region Construtor
        public AlunoAtividade(Guid alunoId, Guid atividadeId, decimal nota) : base(Guid.NewGuid())
        {
            AlunoId = alunoId;
            AtividadeId = atividadeId;
            Nota = nota;
        }
        #endregion
    }
}
