using System.Linq.Expressions;

namespace buyMovies.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAll();//GetAllAsync
        Task<IEnumerable<T>> GetAll(params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(int id, T entity);

        Task DeleteAsync(int id);
    }
}
