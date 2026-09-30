using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SoftPay.Infraestructure
{
    public static class InfrasctructureModule
    {
        public static IServiceCollection AddInfrasctuture(this IServiceCollection services)
        {
            services.AddDbContext<SoftPayContext>(p => p.UseNpgsql("Server=localhost;Port=5490;Database=softpay;User Id=admin;Password=admin;"));

            return services;
        }
    }
}
