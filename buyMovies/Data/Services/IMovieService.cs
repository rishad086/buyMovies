using buyMovies.Data.Base;
using buyMovies.Data.ViewModels;
using buyMovies.Models;

namespace buyMovies.Data.Services
{
    public interface IMovieService:IEntityBaseRepository<Movie>
    {

        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropDownVM> GetNewMovieDropDownsValues();

        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
    }
}
