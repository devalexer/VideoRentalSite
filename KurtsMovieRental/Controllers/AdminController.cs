using KurtsMovieRental.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using KurtsMovieRental.Models;

namespace KurtsMovieRental.Controllers
{
    public class AdminController : Controller
    {

        AdminServices adminServices = new AdminServices();


        public ActionResult Index()
        {
            var movie = new MovieServices().GetAllMovies();
            return View(movie);
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
            adminServices.CreateMovie(newMovie);
            return RedirectToAction("Index");
        }
    }
}
