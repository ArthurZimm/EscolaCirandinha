using EscolaCirandinha.Domain.Entities;

namespace EscolaCirandinha.Domain.Repositories
{
    public interface ICoordenadorRepository : IAsyncRepository<Coordenador>
    {
        Task<Coordenador> RetornaCoordenadorId(Guid id);
        Task<IEnumerable<Coordenador>> RetornaCoordenadores();
    }
}