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
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            var newMovie = new Movie(collection);
            movieServices.CreateMovie(newMovie);
            return RedirectToAction("Index");
        }


        [HttpDelete]
        public ActionResult Delete()
        {
            //var movie = new MovieServices().GetAllMovies();
            return View();

        }

        //[HttpPost]
        //public ActionResult Delete(FormCollection collection, int id)
        //{
        //    var newMovie = new Movie(collection);
        //    movieServices.DeleteMovie(newMovie);
        //    return RedirectToAction("Index");
        //}


    }
}
