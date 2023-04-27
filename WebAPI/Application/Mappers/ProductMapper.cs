using AutoMapper;
using WebAPI.Application.Requests;
using WebAPI.Application.Responses;
using WebAPI.Models.Entities;

namespace WebAPI.Application.Mappers
{
    public class ProductMapper : Profile
    {
        public ProductMapper()
        {
            CreateMap<Product, CreateProductRequest>().ReverseMap();
            CreateMap<Product, ProductResponse>().ReverseMap();
        }
    }
}
