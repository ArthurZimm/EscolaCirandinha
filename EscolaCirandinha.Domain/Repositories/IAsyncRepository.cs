namespace EscolaCirandinha.Domain.Repositories;

public interface IAsyncRepository<T>
{
    Task Adiciona(T obj);
    Task Atualiza(T obj);
    Task Remover(T obj);
}