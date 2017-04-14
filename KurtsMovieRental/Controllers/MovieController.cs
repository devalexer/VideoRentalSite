using KurtsMovieRental.Models;
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

        MovieServices movieServices = new MovieServices();


        public ActionResult Index()
        {
            var newMovies = movieServices.GetAllMovies();
            return View(newMovies);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var movie = new MovieServices().GetAllMovies();
            return View(movie);
        }


        [HttpDelete]
        public ActionResult Delete()
        {
            var movie = new MovieServices().GetAllMovies();
            return View(movie);

        }

    }
}
