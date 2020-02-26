using MoviesWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MoviesWebsite.ViewModels;

namespace MoviesWebsite.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        //protected override void Dispose(bool disposing)
        //{
        //    _context.Dispose();
        //}
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(c => c.Genre).ToList();
            return View(movies);
        }
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }
        public ActionResult MovieForm()
        {
            var genres = _context.Genres.ToList();

            var viewModel = new MovieFormViewModel
            {
                Title = "New Custumer",
                Genres = genres
            };

            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            movie.DateAdded = DateTime.Now;

            if (movie.Id==0)
                _context.Movies.Add(movie);
            else
            {
                Movie MovieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                MovieInDb.Name = movie.Name;
                MovieInDb.ReleaseDate = movie.ReleaseDate;
                MovieInDb.GenreId = movie.GenreId;
                MovieInDb.NumberInStock = movie.NumberInStock;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            var viewModel = new MovieFormViewModel
            {
                Title = "Edit Customer",
                Movie = movie,
                Genres = _context.Genres.ToList()
            };

            return View("MovieForm", viewModel);
        }

    }
}