using buyMovies.Data;
using buyMovies.Data.Services;
using buyMovies.Models;
using Microsoft.AspNetCore.Mvc;

namespace buyMovies.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }

        public async Task<IActionResult>Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }
        //Get request
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Actor actor)
        {
            if (ModelState.IsValid) //ekhane !ModelState.IsValid howar kotha chilo but Shudu ModelState.IsValid dile kaj hocche
            {
                return View(actor);
            }
            
                await _service.AddAsync(actor);
                return RedirectToAction(nameof(Index));
            
            
        }
        //Get: Actors/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails =await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("Empty");
            return View(actorDetails);

        }


    }
}
