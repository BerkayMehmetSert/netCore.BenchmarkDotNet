using Microsoft.EntityFrameworkCore;
using WebAPI.Application.Repositories;
using WebAPI.Persistence.Context;
using WebAPI.Persistence.Repositories;

namespace WebAPI.Persistence
{
    public static class ServiceExtensions
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<BaseDbContext>(options =>
            {
                options.UseInMemoryDatabase("InMemoryDbForTesting");
            });
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
