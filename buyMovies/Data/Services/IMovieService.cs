using buyMovies.Data.Base;
using buyMovies.Models;

namespace buyMovies.Data.Services
{
    public interface IMovieService:IEntityBaseRepository<Movie>
    {

        Task<Movie> GetMovieByIdAsync(int id);
    }
}
