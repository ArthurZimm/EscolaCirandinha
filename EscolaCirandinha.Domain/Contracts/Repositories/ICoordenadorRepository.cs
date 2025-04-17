using EscolaCirandinha.Domain.Entities;

namespace EscolaCirandinha.Domain.Contracts.Repositories
{
    public interface ICoordenadorRepository : IAsyncRepository<Coordenador>
    {
        Task<Coordenador?> ObtemCoordenadorId(Guid id);
        Task<IEnumerable<Coordenador>?> ObtemCoordenadores();
    }
}