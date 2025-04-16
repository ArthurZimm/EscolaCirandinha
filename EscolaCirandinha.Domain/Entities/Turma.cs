using EscolaCirandinha.Domain.Shared.Entities;

namespace EscolaCirandinha.Domain.Entities
{
    public sealed class Turma : Entity
    {
        #region Propriedades
        public string Nome { get; private set; }
        public ICollection<Aluno> Alunos { get; private set; }
        #endregion

        #region Construtor
        public Turma(string nome, ICollection<Aluno> alunos) : base(Guid.NewGuid())
        {
            Nome = nome;
            Alunos = alunos;
        }
        #endregion
    }
}