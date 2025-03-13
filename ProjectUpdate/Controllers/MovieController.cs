using Microsoft.AspNetCore.Mvc;
using ProjectUpdate.Models;
using ProjectUpdate.Services;
using System.Collections.Generic;
using System.Linq;

namespace ProjectUpdate.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MovieController(ApplicationDbContext context)
        {
            _context = context;
        }

        // API to get movie data in JSON format
        [HttpGet]
        public JsonResult GetMovies()
        {
            var movies = _context.Movie
                .Select(m => new
                {
                    m.Id,
                    m.Title,
                    m.ImageURL,
                    m.Genre,
                    m.Producer,
                    m.Actor,
                    m.Description,
                    m.StartTime,
                    m.EndTime,
                    m.Price
                })
                .ToList();

            return Json(movies);
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create(Movies movie)
        {
            if (ModelState.IsValid)
            {
                _context.Movie.Add(movie);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        //public IActionResult Create()
        //{
        //    return View();
        //}
    }
}