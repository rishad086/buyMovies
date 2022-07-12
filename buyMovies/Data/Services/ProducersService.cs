using buyMovies.Data.Base;
using buyMovies.Models;

namespace buyMovies.Data.Services
{
    public class ProducersService:EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
             
        }
    }
}
