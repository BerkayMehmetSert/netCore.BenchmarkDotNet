using WebAPI.Application.Repositories;
using WebAPI.Models.Entities;
using WebAPI.Persistence.Context;

namespace WebAPI.Persistence.Repositories
{
    public class ProductRepository:BaseRepository<Product, BaseDbContext>, IProductRepository
    {
        public ProductRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
