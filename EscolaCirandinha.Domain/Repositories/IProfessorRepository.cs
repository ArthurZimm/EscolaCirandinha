using EscolaCirandinha.Domain.Entities;

namespace EscolaCirandinha.Domain.Repositories;

public interface IProfessorRepository : IAsyncRepository<Professor>
{
    Task<ICollection<Professor>> RetornaProfessores();
    Task<ICollection<Professor>> RetornaProfessorTurma(string turma);
    Task<Professor> RetornaProfessorCpf(string cpf);
    Task<Professor> RetornaProfessorId(Guid id);
}