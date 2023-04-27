using AutoMapper;
using WebAPI.Application.Repositories;
using WebAPI.Application.Requests;
using WebAPI.Application.Responses;
using WebAPI.Models.Entities;

namespace WebAPI.Application.Services
{
    public class ProductManager : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductManager(IProductRepository productRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ProductResponse> CreateProduct(CreateProductRequest request)
        {
            var product = _mapper.Map<Product>(request);

            _productRepository.Add(product);
            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<ProductResponse>(product);
        }

        public async Task<ProductResponse> UpdateProduct(Guid id, UpdateProductRequest request)
        {
            var product = await GetProduct(id);

            product.Name = request.Name;
            product.Price = request.Price;

            _productRepository.Update(product);
            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<ProductResponse>(product);
        }

        public async Task<ProductResponse> DeleteProduct(Guid id)
        {
            var product = await GetProduct(id);

            _productRepository.Delete(product);
            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<ProductResponse>(product);
        }

        public async Task<ProductResponse> GetProductById(Guid id)
        {
            var product = await _productRepository.Get(x => x.Id == id);

            return _mapper.Map<ProductResponse>(product);
        }

        public async Task<List<ProductResponse>> GetProducts()
        {
            var products = await _productRepository.GetAll();
            return _mapper.Map<List<ProductResponse>>(products);
        }

        private async Task<Product> GetProduct(Guid id) => await _productRepository.Get(x => x.Id == id);
    }
}
