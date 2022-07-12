using buyMovies.Data.Base;
using buyMovies.Models;
using Microsoft.EntityFrameworkCore;

namespace buyMovies.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {

        public ActorsService(AppDbContext context) :base(context) { }
        


       
    }
}
