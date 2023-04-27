using WebAPI.Application.Requests;
using WebAPI.Application.Responses;

namespace WebAPI.Application.Services
{
    public interface IProductService
    {
        Task<ProductResponse> CreateProduct(CreateProductRequest request);
        Task<ProductResponse> UpdateProduct(Guid id, UpdateProductRequest request);
        Task<ProductResponse> DeleteProduct(Guid id);
        Task<ProductResponse> GetProductById(Guid id);
        Task<List<ProductResponse>> GetProducts();
    }
}
