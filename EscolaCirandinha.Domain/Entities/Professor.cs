using EscolaCirandinha.Domain.Shared.Entities;
using EscolaCirandinha.Domain.Shared.Validations;
using EscolaCirandinha.Domain.Shared.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace EscolaCirandinha.Domain.Entities
{
    public sealed class Professor : Entity
    {
        #region Propriedades
        public DadosPessoais DadosProfessor { get; }
        [CustomValidation(typeof(Validation), nameof(Validation.ValidaForcaSenha))]
        public string Senha { get; private set; }
        public ICollection<Turma> Turmas { get; private set; }
        public ICollection<Materia> Materias { get; private set; }
        #endregion

        #region Construtor
        public Professor(DadosPessoais dadosProfessor, string senha, ICollection<Turma> turmas, ICollection<Materia> materias) : base(Guid.NewGuid())
        {
            DadosProfessor = dadosProfessor;
            Senha = senha;
            Turmas = turmas;
            Materias = materias;
        }
        #endregion

        #region Métodos
        public void AlterarSenha(string novaSenha)
        {
            Senha = novaSenha;
        }
        #endregion
    }
}