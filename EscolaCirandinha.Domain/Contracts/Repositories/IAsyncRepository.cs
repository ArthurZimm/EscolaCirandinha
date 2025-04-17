namespace EscolaCirandinha.Domain.Contracts.Repositories;

public interface IAsyncRepository<T>
{
    Task Adiciona(T obj);
    Task Atualiza(T obj);
    Task Remover(T obj);
}