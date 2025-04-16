using EscolaCirandinha.Domain.Shared.Entities;

namespace EscolaCirandinha.Domain.Entities
{
    public sealed class ProfessorMateria : Entity
    {
        #region Propriedades
        public Guid ProfessorId { get; private set; }
        public Guid MateriaId { get; private set; }
        public List<Atividade> Atividades { get; private set; }
        #endregion

        #region Construtor
        public ProfessorMateria(Guid professorId, Guid materiaId) : base(Guid.NewGuid())
        {
            ProfessorId = professorId;
            MateriaId = materiaId;
        }
        #endregion
    }
}