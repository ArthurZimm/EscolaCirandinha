using EscolaCirandinha.Domain.Shared.Validations;
using System.ComponentModel.DataAnnotations;

namespace EscolaCirandinha.Domain.Shared.ValueObjects
{
    public sealed record Endereco : ValueObject
    {
        [Required(ErrorMessage = "A rua é obrigatória.")]
        public string Rua { get; }
        [Required(ErrorMessage = "O número é obrigatório.")]
        public int Numero { get; }
        [Required(ErrorMessage = "O bairro é obrigatório.")]
        public string Bairro { get; }
        [Required(ErrorMessage = "A cidade é obrigatória.")]
        public string Cidade { get; }
        [Required(ErrorMessage = "O estado é obrigatório.")]
        public string Estado { get; }
        [Required(ErrorMessage = "O CEP é obrigatório.")]
        [CustomValidation(typeof(Validation), nameof(Validation.ValidaCep))]
        public string Cep { get; }

        public Endereco(string rua, int numero, string bairro, string cidade, string estado, string cep)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
        }
    }
}