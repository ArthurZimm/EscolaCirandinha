using EscolaCirandinha.Domain.Shared.Entities;

namespace EscolaCirandinha.Domain.Entities
{
    public sealed class AlunoAtividade : Entity
    {

        #region Propriedades
        public Guid AlunoId { get; private set; }
        public Aluno Aluno { get; private set; }
        public Guid AtividadeId { get; private set; }
        public Atividade Atividade { get; private set; }
        public decimal Nota { get; private set; }
        #endregion

        #region Construtor
        public AlunoAtividade() : base(Guid.NewGuid())
        {
            
        }
        public AlunoAtividade(Guid alunoId, Aluno aluno, Guid atividadeId, Atividade atividade, decimal nota) : base(Guid.NewGuid())
        {
            AlunoId = alunoId;
            Aluno = aluno;
            AtividadeId = atividadeId;
            Atividade = atividade;
            Nota = nota;
        }
        #endregion
    }
}
