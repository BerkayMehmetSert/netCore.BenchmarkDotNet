using WebAPI.Models.Common;

namespace WebAPI.Models.Entities
{
    public sealed class Product : BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
