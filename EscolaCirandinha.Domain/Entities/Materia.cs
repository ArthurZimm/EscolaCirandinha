using EscolaCirandinha.Domain.Shared.Entities;
using System.ComponentModel.DataAnnotations;

namespace EscolaCirandinha.Domain.Entities
{
    public sealed class Materia : Entity
    {
        #region Propriedades
        [Required(ErrorMessage = "O nome da matéria é obrigatório.")]
        public string Nome { get; private set; }
        public ICollection<ProfessorMateria> ProfessorMaterias { get; private set; }

        #endregion
        #region Construtor
        public Materia() : base(Guid.NewGuid())
        {
            
        }
        public Materia(string nome, ICollection<ProfessorMateria>professorMaterias) : base(Guid.NewGuid())
        {
            Nome = nome;
            ProfessorMaterias = professorMaterias;
        }
        #endregion
        #region Métodos
        public void AlterarNome(string novoNome)
        {
            Nome = novoNome;
        }
        #endregion
    }
}