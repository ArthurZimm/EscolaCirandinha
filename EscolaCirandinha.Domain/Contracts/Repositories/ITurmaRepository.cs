using EscolaCirandinha.Domain.Entities;

namespace EscolaCirandinha.Domain.Contracts.Repositories
{
    public interface ITurmaRepository : IAsyncRepository<Turma>
    {
        Task<IEnumerable<Turma>?> ObtemTurmas();
        Task<Turma?> ObtemTurmaId(Guid id);
        Task<Turma?> ObtemTurmaNome(string nome);
        Task<IEnumerable<Turma>?> ObtemTurmasProfessor(Guid professorId);
    }
}