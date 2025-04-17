using EscolaCirandinha.Domain.Shared.Entities;

namespace EscolaCirandinha.Domain.Entities
{
    public sealed class Atividade : Entity
    {

        #region Propriedades
        public Guid TurmaId { get; private set; }
        public Turma Turma { get; private set; }

        public string Avaliacao { get; private set; }
        public decimal NotaMaxima { get; private set; }

        public ICollection<AlunoAtividade> AlunoAtividades { get; private set; }
        #endregion
        #region Construtores
        public Atividade() : base(Guid.NewGuid())
        {
            
        }
        public Atividade(Guid turmaId, Turma turma, string avaliacao,
            decimal notaMaxima, ICollection<AlunoAtividade> alunoAtividades) : base(Guid.NewGuid())
        {
            TurmaId = turmaId;
            Turma = turma;
            Avaliacao = avaliacao;
            NotaMaxima = notaMaxima;
            AlunoAtividades = alunoAtividades;
        }
        #endregion
    }
}