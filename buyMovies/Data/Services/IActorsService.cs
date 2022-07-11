using buyMovies.Models;

namespace buyMovies.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAll();//GetAllAsync
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Actor Update(int id,Actor newActor);

        void Delete(int id);
       
    }
}
