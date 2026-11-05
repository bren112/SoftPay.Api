using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SoftPay.Infraestructure
{
    public static class InfrasctructureModule
    {
        public static IServiceCollection AddInfrasctuture(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("SoftPay")
                ?? throw new InvalidOperationException("A conexão 'SoftPay' não foi configurada.");

            services.AddDbContext<SoftPayContext>(options => options.UseNpgsql(connectionString));

            return services;
        }
    }
}
