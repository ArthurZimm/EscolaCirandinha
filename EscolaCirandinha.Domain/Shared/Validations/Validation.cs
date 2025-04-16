using System.ComponentModel.DataAnnotations;

namespace EscolaCirandinha.Domain.Shared.Validations
{
    public static class Validation
    {
        #region Validações
        public static ValidationResult ValidaForcaSenha(string senha)
        {
            if (senha.Length < 8)
                return new ValidationResult("A senha deve ter pelo menos 8 caracteres.");
            if (!senha.Any(char.IsUpper))
                return new ValidationResult("A senha deve conter pelo menos uma letra maiúscula.");
            if (!senha.Any(char.IsLower))
                return new ValidationResult("A senha deve conter pelo menos uma letra minúscula.");
            if (!senha.Any(char.IsDigit))
                return new ValidationResult("A senha deve conter pelo menos um dígito.");
            if (!senha.Any(ch => !char.IsLetterOrDigit(ch)))
                return new ValidationResult("A senha deve conter pelo menos um caractere especial.");

            return ValidationResult.Success;
        }
        public static ValidationResult ValidaCpf(string cpf)
        {
            if (string.IsNullOrEmpty(cpf))
                return new ValidationResult("O CPF não pode ser nulo ou vazio.");
            if (cpf.Length != 11)
                return new ValidationResult("O CPF deve ter 11 dígitos.");
            if (!cpf.All(char.IsDigit))
                return new ValidationResult("O CPF deve conter apenas dígitos.");

            return ValidationResult.Success;
        }
        public static ValidationResult ValidaDataNascimento(DateTime dataNascimento)
        {
            if (dataNascimento > DateTime.Now)
                return new ValidationResult("A data de nascimento não pode ser futura.");
            if (dataNascimento < DateTime.Now.AddYears(-100))
                return new ValidationResult("A data de nascimento não pode ser mais antiga que 100 anos.");

            return ValidationResult.Success;
        }
        public static ValidationResult ValidaCep(string cep)
        {
            if (string.IsNullOrEmpty(cep))
                return new ValidationResult("O CEP não pode ser nulo ou vazio.");
            if (cep.Length != 8)
                return new ValidationResult("O CEP deve ter 8 dígitos.");
            if (!cep.All(char.IsDigit))
                return new ValidationResult("O CEP deve conter apenas dígitos.");

            return ValidationResult.Success;
        }
        #endregion
    }
}