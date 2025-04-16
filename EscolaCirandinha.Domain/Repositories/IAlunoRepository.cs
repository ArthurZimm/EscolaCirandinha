using EscolaCirandinha.Domain.Entities;

namespace EscolaCirandinha.Domain.Repositories;

public interface IAlunoRepository : IAsyncRepository<Aluno>
{
    Task<ICollection<Aluno>> RetornaAlunosTurma(string turma);
    Task<Aluno> RetornaAlunoId(Guid id);
    Task<Aluno> RetornaAlunoCpf(string cpf);
}