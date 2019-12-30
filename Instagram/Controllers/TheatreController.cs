using Instagram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Instagram.Controllers
{
    public class TheatreController : Controller
    {
        // GET: Theatre/Hall
        public ActionResult Hall()
        {
            var hal = new Theatre() { Name = "Brudhavana Colony" };
            /*ISet<Theatre> the = new HashSet<Theatre>();
            the.Add(new Theatre { Name = "urvasi" });
            the.Add(new Theatre { Name = "Multiplex" });
            the.Add(new Theatre { Name = "bhimavaramHall" });
            foreach (var nam in the) */

                return View(hal);
            
           
            
        }
        public ActionResult Edit(int id)
        {
            return Content(id + "You entered id is");
        }
    }
}