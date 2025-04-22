using EscolaCirandinha.Domain.Entities;
using EscolaCirandinha.Domain.Shared.ValueObjects;

namespace EscolaCirandinha.Application.DTOs
{
    public class AlunoDto
    {
        public AlunoDto(DadosPessoais dadosAluno, Endereco endereco, Responsavel responsavel, Guid turmaId, Turma turma, ICollection<AlunoAtividade> alunoAtividades)
        {
            DadosAluno = dadosAluno;
            Endereco = endereco;
            Responsavel = responsavel;
            TurmaId = turmaId;
            Turma = turma;
            AlunoAtividades = alunoAtividades;
        }

        public DadosPessoais DadosAluno{ get; set; }
        public Endereco Endereco { get; set; }
        public Responsavel Responsavel { get; set; }
        public Guid TurmaId { get; set; }
        public Turma Turma { get; set; }
        public ICollection<AlunoAtividade> AlunoAtividades { get; set; }
    }
}