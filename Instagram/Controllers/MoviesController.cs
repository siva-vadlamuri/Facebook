using Instagram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Instagram.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movies() { Name = "Baahubali" };
            //return Content("movie");
            return View(movie);
            //return HttpNotFound();
            
        }
      
    }
}