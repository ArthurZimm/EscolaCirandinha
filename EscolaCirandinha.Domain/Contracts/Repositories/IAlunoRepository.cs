using EscolaCirandinha.Domain.Entities;

namespace EscolaCirandinha.Domain.Contracts.Repositories;

public interface IAlunoRepository : IAsyncRepository<Aluno>
{
    Task<IEnumerable<Aluno>?> ObtemAlunosTurma(Guid turma);
    Task<Aluno?> ObtemAlunoId(Guid id);
    Task<Aluno?> ObtemAlunoCpf(string cpf);
}