using EscolaCirandinha.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EscolaCirandinha.Infra.Ioc
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServiceConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddScoped<IAlunoRepository, AlunoRepository>();
            //services.AddScoped<IAtividadeRepository, AtividadeRepository>();
            //services.AddScoped<ICoordenadorRepository, CoordenadorRepository>();
            //services.AddScoped<ITurmaRepository, TurmaRepository>();

            services.AddDbContext<ApplicationDbContext>(options => 
                                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}