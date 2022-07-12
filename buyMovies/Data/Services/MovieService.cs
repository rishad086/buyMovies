﻿using buyMovies.Data.Base;
using buyMovies.Models;
using Microsoft.EntityFrameworkCore;

namespace buyMovies.Data.Services
{
    public class MovieService:EntityBaseRepository<Movie>,IMovieService
    {
        private readonly AppDbContext _context;
        public MovieService(AppDbContext context):base(context)
        {
            _context = context;
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            var movieDetails = await _context.Movies
                .Include(c => c.Cinema)
                .Include(p => p.Producer)
                .Include(am => am.Actors_Movies).ThenInclude(a => a.Actor)
                .FirstOrDefaultAsync(n => n.Id == id);

            return  movieDetails;
        }
    }
}
