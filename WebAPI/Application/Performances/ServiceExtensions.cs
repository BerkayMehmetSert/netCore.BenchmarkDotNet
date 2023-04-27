namespace WebAPI.Application.Performances
{
    public static class ServiceExtensions
    {
        public static void AddBenchmarkServices(this IServiceCollection services)
        {
            services.AddSingleton<ProductsControllerBenchmark>();
        }
    }
}
