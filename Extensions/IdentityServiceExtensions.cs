using DwitterLoungeBar.Data;
using Microsoft.AspNetCore.Identity;

namespace DwitterLoungeBar.Extensions
{
    public static class IdentityServiceExtensions
    {
        public static IServiceCollection AddIdentityExtenisons(this IServiceCollection services, IConfiguration config)
        {
            services.AddIdentity<IdentityUser, IdentityRole>(opt =>
            {
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequireDigit = false;
            })
              .AddEntityFrameworkStores<AppDbContext>();

            return services;
        }
    }
}
