﻿using EscolaCirandinha.Domain.Shared.Entities;
using EscolaCirandinha.Domain.Shared.Validations;
using EscolaCirandinha.Domain.Shared.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace EscolaCirandinha.Domain.Entities
{
    public sealed class Aluno : Entity
    {
        #region Propriedades
        [Required(ErrorMessage = "Os dados pessoais são obrigatórios.")]
        public DadosPessoais DadosAluno { get; private set; }
        [Required(ErrorMessage = "O endereço é obrigatório.")]
        public Endereco Endereco { get; private set; }
        [Required(ErrorMessage = "O responsável é obrigatório.")]
        public Responsavel Responsavel { get; private set; }
        [Required(ErrorMessage = "A senha é obrigatória.")]
        [CustomValidation(typeof(Validation), nameof(Validation.ValidaForcaSenha))]
        public string Senha { get; private set; }
        public Guid TurmaId { get; private set; }
        public Turma Turma { get; private set; }
        public ICollection<AlunoAtividade> AlunoAtividades { get; private set; }
        #endregion

        #region Construtor
        public Aluno() : base(Guid.NewGuid())
        {
            
        }
        public Aluno(DadosPessoais dadosAluno, Endereco endereco, Responsavel responsavel,
            string senha,Guid turmaId) : base(Guid.NewGuid())
        {
            DadosAluno = dadosAluno;
            Endereco = endereco;
            Responsavel = responsavel;
            Senha = senha;
            TurmaId = turmaId;
            AlunoAtividades = new List<AlunoAtividade>();
        }
        #endregion

        #region Métodos
        public void AlterarEndereco(Endereco novoEndereco)
        {
            Endereco = novoEndereco;
        }
        public void AlterarSenha(string novaSenha)
        {
            Senha = novaSenha;
        }
        public void AlterarTurma(Turma novaTurma)
        {
            Turma = novaTurma;
        }

        #endregion
    }
}