using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            //return View(movie);


            //Other things that can be returned
            //return Content("Yo! Waddidu?");
            //return HttpNotFound();
            //return new EmptyResult();
            return RedirectToRoute("Home", "Index");
        }

        //Attribute route
        [Route("movies/release/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }



    }
}