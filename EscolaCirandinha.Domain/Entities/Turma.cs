using EscolaCirandinha.Domain.Shared.Entities;

namespace EscolaCirandinha.Domain.Entities
{
    public sealed class Turma : Entity
    {
        #region Propriedades
        public string Nome { get; private set; }
        public Guid ProfessorId { get; private set; }
        public Professor Professor { get; private set; }
        public ICollection<Aluno> Alunos { get; private set; }
        public ICollection<Atividade> Atividades { get; private set; }
        #endregion

        #region Construtor
        public Turma() : base(Guid.NewGuid())
        {
            
        }
        public Turma(string nome, Guid professorId, Professor professor, ICollection<Aluno> alunos, ICollection<Atividade> atividades) : base(Guid.NewGuid())
        {
            Nome = nome;
            ProfessorId = professorId;
            Professor = professor;
            Alunos = alunos;
            Atividades = atividades;
        }
        #endregion
    }
}