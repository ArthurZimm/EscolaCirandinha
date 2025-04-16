using EscolaCirandinha.Domain.Shared.Entities;
using EscolaCirandinha.Domain.Shared.Validations;
using EscolaCirandinha.Domain.Shared.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace EscolaCirandinha.Domain.Entities
{
    public sealed class Coordenador : Entity
    {
        #region Propriedades
        public DadosPessoais DadosCoordenador { get; }
        [Required(ErrorMessage = "a senha é obrigatória.")]
        [CustomValidation(typeof(Validation), nameof(Validation.ValidaForcaSenha))]
        public string Senha { get; private set; }
        #endregion

        #region Construtor
        public Coordenador(DadosPessoais dadosCoordenador, string senha) : base(Guid.NewGuid())
        {
            DadosCoordenador = dadosCoordenador;
            Senha = senha;
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