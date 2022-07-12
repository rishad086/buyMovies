using buyMovies.Data.Base;
using buyMovies.Models;

namespace buyMovies.Data.Services
{
    public class CinemasService:EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {

        }
    }
}
