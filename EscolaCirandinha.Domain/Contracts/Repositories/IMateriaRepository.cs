using EscolaCirandinha.Domain.Entities;

namespace EscolaCirandinha.Domain.Contracts.Repositories
{
    public interface IMateriaRepository : IAsyncRepository<Materia>
    {
        Task<IEnumerable<Materia>?> ObtemMaterias();
        Task<Materia?> ObtemMateriaId(Guid id);
    }
}