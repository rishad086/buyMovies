using buyMovies.Models;
using Microsoft.EntityFrameworkCore;

namespace buyMovies.Data.Services
{
    public class ActorsService : IActorsService
    {

        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context)
        {
            _context = context;
        }


        public  async Task AddAsync(Actor actor)
        {
           await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Actor>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var result =await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            return result;
           
        }

     

        public Actor Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }

        



        //public Task<IEnumerable<Actor>> GetAllAsync()
        // {
        //  throw new NotImplementedException();
        //}
    }
}
