using EscolaCirandinha.Domain.Shared.Entities;
using System.ComponentModel.DataAnnotations;

namespace EscolaCirandinha.Domain.Entities
{
    public sealed class Materia : Entity
    {
        #region Propriedades
        [Required(ErrorMessage = "O nome da matéria é obrigatório.")]
        public string Nome { get; private set; }
        #endregion
        #region Construtor
        public Materia(string nome) : base(Guid.NewGuid())
        {
            Nome = nome;
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