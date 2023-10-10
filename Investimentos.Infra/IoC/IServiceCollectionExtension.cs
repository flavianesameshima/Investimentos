using Investimentos.Domain.Interfaces.Repositories;
using Investimentos.Domain.Interfaces.Services;
using Investimentos.Domain.Services;
using Investimentos.Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Investimentos.Infra.IoC
{
   public static class IServiceCollectionExtension
    {
        public static void RegisterApplicationDependencies(this IServiceCollection services)
        {
            //services
            services.AddTransient<IContaService, ContaService>();

            //repositories
            services.AddTransient<IContaRepository, ContaRepository>();
        }
    }
}
