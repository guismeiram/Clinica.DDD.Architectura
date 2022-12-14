using Clinica.DDD.Architectura.Domain.Entities;
using Clinica.DDD.Architectura.Domain.Interfaces;
using Clinica.DDD.Architectura.Infra.Data.Context;
using Clinica.DDD.Architectura.Infra.Data.Repository;
using Clinica.DDD.Architectura.Service.Services;

namespace Clinica.DDD.Architectura.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<ClinicaDbContext>();
            services.AddScoped<IConsultaRepository, ConsultaRepository>();


            services.AddScoped<IConsultaService<Entity>, ConsultaService<Entity>>();

            return services;
        }
    }
}
