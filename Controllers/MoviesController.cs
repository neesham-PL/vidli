using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidli.Models;
using vidli.ViewModel;

namespace vidli.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random

        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private object GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id = 1, Name = "Shrek"},
                new Movie{Id =2, Name = "Wall-e"}
            };
        }

        public ActionResult Random()
        {
            var movie = new Movie()  
            {
                Name = "Shrek!"
            };
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var ViewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers  
            };
            //ViewData["Movie"] = movie;
            return View(ViewModel);
            //return Content("Hello");
            //return HttpNotFound();
            //return new EmptyResult()
            //return RedirectToAction("Index", "Home", new { page =, sortBy = "name" });
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //    {
        //        pageIndex = 1;
        //    }
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //    {
        //        sortBy = "Name";
        //    }
        //    return Content(String.Format($"sortby is {sortBy} & and pageIndex is {pageIndex}"));
        //}
    }
}