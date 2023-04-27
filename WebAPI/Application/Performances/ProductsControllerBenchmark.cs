using BenchmarkDotNet.Attributes;

namespace WebAPI.Application.Performances
{
    [MemoryDiagnoser]
    public class ProductsControllerBenchmark
    {
        private HttpClient _httpClient;

        [GlobalSetup]
        public void GlobalSetup()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5019");
        }

        [Benchmark]
        public async Task GetProducts()
        {
            var response = await _httpClient.GetAsync("/api/Products");

            var content = await response.Content.ReadAsStringAsync();
        }
    }
}
