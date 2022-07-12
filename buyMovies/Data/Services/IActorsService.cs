using buyMovies.Models;

namespace buyMovies.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAll();//GetAllAsync
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Task<Actor> UpdateAsync(int id,Actor newActor);

        Task DeleteAsync(int id);
       
    }
}
