namespace EscolaCirandinha.Domain.Contracts.Services
{
    public interface IEmailService
    {
        Task EnviarEmail(string emailDestino, string assunto, string mensagem);
    }
}