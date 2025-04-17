using EscolaCirandinha.Domain.Entities;
using EscolaCirandinha.Domain.Shared.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace EscolaCirandinha.Test.Domain.Entities
{
    public class AlunoTests
    {
        private Guid turmaId = Guid.NewGuid();
        private Aluno CriarAlunoValido()
        {
            var dadosPessoais = new DadosPessoais("Arthur Z", "12345678910", new DateTime(2002, 02, 20));
            var endereco = new Endereco("Rua A", 8, "Centro", "Espirito Santo", "ES", "29111666");
            var responsavel = new Responsavel(
                               new DadosPessoais("Minha Mãe", "98765432112", new DateTime(1992, 01, 30)),
                                              new DadosPessoais("Meu Pai", "45678912354", new DateTime(1985, 12, 25))
                                                         );
            var senha = "SenhaForte123!";

            return new Aluno(dadosPessoais, endereco, responsavel, senha, turmaId);
        }

        [Fact]
        public void CriarAluno_DeveCriarComDadosValidos()
        {

            
            // Act
            var aluno = CriarAlunoValido();
            // Assert
            Assert.Equal("Arthur Z", aluno.DadosAluno.Nome);
            Assert.Equal("12345678910", aluno.DadosAluno.Cpf);
            Assert.Equal("Espirito Santo", aluno.Endereco.Cidade);
            Assert.Equal(8, aluno.Endereco.Numero);
            Assert.Equal("Minha Mãe", aluno.Responsavel.Mae.Nome);
            Assert.Equal("Meu Pai", aluno.Responsavel.Pai!.Nome);
            Assert.Equal("SenhaForte123!", aluno.Senha);
            Assert.Equal(turmaId, aluno.TurmaId);
        }

        [Fact]
        public void CriarAluno_DeveFalhar_QuandoSenhaFraca()
        {
            // Arrange
            var dadosPessoais = new DadosPessoais("Arthur Z", "12345678910", new DateTime(2002, 02, 20));
            var endereco = new Endereco("Rua A", 8, "Centro", "Espirito Santo", "ES", "29111666");
            var responsavel = new Responsavel(
                new DadosPessoais("Minha Mãe", "98765432112", new DateTime(1992, 01, 30)),
                new DadosPessoais("Meu Pai", "45678912354", new DateTime(1985, 12, 25))
            );
            var senhaFraca = "123";
            var turmaId = Guid.NewGuid();

            var aluno = new Aluno(dadosPessoais, endereco, responsavel, senhaFraca, turmaId);

            // Act
            var context = new ValidationContext(aluno);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(aluno, context, results, true);

            // Assert
            Assert.False(isValid);
            Assert.Contains(results, r => r.ErrorMessage.Contains("senha", StringComparison.OrdinalIgnoreCase));
        }

        [Fact]
        public void AlterarEndereco_DeveAtualizarEndereco()
        {
            // Arrange
            var aluno = CriarAlunoValido();
            var novoEndereco = new Endereco("Rua Nova", 20, "Bairro Novo", "Vila Velha", "ES", "29111777");

            // Act
            aluno.AlterarEndereco(novoEndereco);

            // Assert
            Assert.Equal("Rua Nova", aluno.Endereco.Rua);
            Assert.Equal(20, aluno.Endereco.Numero);
        }
        [Fact]
        public void AlterarSenha_DeveAtualizarSenha()
        {
            // Arrange
            var aluno = CriarAlunoValido();
            var novaSenha = "NovaSenhaForte456!";

            // Act
            aluno.AlterarSenha(novaSenha);

            // Assert
            Assert.Equal(novaSenha, aluno.Senha);
        }
    }
}
