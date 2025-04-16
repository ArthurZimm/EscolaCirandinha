using EscolaCirandinha.Domain.Shared.Validations;
using System.ComponentModel.DataAnnotations;

namespace EscolaCirandinha.Domain.Shared.ValueObjects
{
    public sealed record DadosPessoais : ValueObject
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; }
        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [CustomValidation(typeof(Validation), nameof(Validation.ValidaCpf))]
        public string Cpf { get; }
        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        [CustomValidation(typeof(Validation), nameof(Validation.ValidaDataNascimento))]
        public DateTime DataNascimento { get; }

        public DadosPessoais(string nome, string cpf, DateTime dataNascimento)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
        }
    }
}