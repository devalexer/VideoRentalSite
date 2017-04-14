using KurtsMovieRental.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace KurtsMovieRental.Controllers
{
    public class MovieController : Controller
    {

        [HttpGet]
        public ActionResult FullMovieList()
        {
            var movie = new MovieServices().GetAllMovies();
            return View(movie);
        }

        [HttpGet]
        public ActionResult AdminView()
        {
            var movie = new MovieServices().GetAllMovies();
            return View(movie);
        }


    }
}
