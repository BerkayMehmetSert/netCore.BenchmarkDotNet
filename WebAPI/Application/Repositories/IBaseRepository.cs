using System.Linq.Expressions;
using WebAPI.Models.Common;

namespace WebAPI.Application.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<T> Get(Expression<Func<T, bool>> predicate);
        Task<List<T>> GetAll(Expression<Func<T, bool>>? predicate = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
