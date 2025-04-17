using EscolaCirandinha.Domain.Entities;

namespace EscolaCirandinha.Domain.Contracts.Repositories;

public interface IProfessorRepository : IAsyncRepository<Professor>
{
    Task<IEnumerable<Professor>?> ObtemProfessores();
    Task<IEnumerable<Professor>?> ObtemProfessorTurma(string turma);
    Task<Professor?> ObtemProfessorCpf(string cpf);
    Task<Professor?> ObtemProfessorId(Guid id);
}