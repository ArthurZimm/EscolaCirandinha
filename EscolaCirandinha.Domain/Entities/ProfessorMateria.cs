using EscolaCirandinha.Domain.Shared.Entities;

namespace EscolaCirandinha.Domain.Entities
{
    public sealed class ProfessorMateria : Entity
    {
        #region Propriedades
        public Guid ProfessorId { get; private set; }
        public Professor Professor { get; private set; }
        public Guid MateriaId { get; private set; }
        public Materia Materia { get; private set; }
        public ICollection<Atividade> Atividades { get; private set; }
        #endregion

        #region Construtor
        public ProfessorMateria() : base(Guid.NewGuid())
        {
            
        }
        public ProfessorMateria(Guid professorId, Professor professor, Guid materiaId, Materia materia, ICollection<Atividade> atividades) : base(Guid.NewGuid())
        {
            ProfessorId = professorId;
            Professor = professor;
            MateriaId = materiaId;
            Materia = materia;
            Atividades = atividades;
        }
        #endregion
    }
}