using EscolaCirandinha.Domain.Entities;

namespace EscolaCirandinha.Domain.Contracts.Repositories
{
    public interface IAlunoAtividadeRepository : IAsyncRepository<AlunoAtividade>
    {
        Task<IEnumerable<AlunoAtividade>?> ObtemAlunosAtividadesAtividadeId(Guid atividadeId);
        Task<AlunoAtividade?> ObtemAlunosAtividadesAlunoId(Guid alunoId);
        Task<IEnumerable<AlunoAtividade>?> ObtemAlunosAtividadesTurmaId(Guid turmaId);
    }
}