using buyMovies.Data;
using buyMovies.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace buyMovies.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieService _service;

        public MoviesController(IMovieService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _service.GetAll(n => n.Cinema);
            return View(allMovies);
        }

        //Get:movies/details
        public async Task<IActionResult> Details(int id)
        {
            var movieDetail = await _service.GetMovieByIdAsync(id);
        return View(movieDetail);
        }

        //Get: Movies/Create
        public IActionResult Create()
        {
            ViewData["Welcome"] = "Welcome to our store";

            ViewBag.Description = "This is the store description";
            return View();
        }
    }
}
