using System.Reflection;
using WebAPI.Application.Services;

namespace WebAPI.Application
{
    public static class ServiceExtensions
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<IProductService, ProductManager>();
        }
    }
}
