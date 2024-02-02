using DwitterLoungeBar.Data;
using DwitterLoungeBar.Interfaces;
using DwitterLoungeBar.Models;
using DwitterLoungeBar.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DwitterLoungeBar.Extensions
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddApplicationExtensions(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(config.GetConnectionString("localhost"));
            });

            services.AddTransient<IDrinkRepository, DrinkRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();


            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShoppingCart.GetCart(sp));


            return services;
        }
    }
}
