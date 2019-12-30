using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Instagram.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "We are developing a .net Page";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "For any Querys conntact me Phone:7659836636.";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "This is your login page";
            return View();
        }
    }
}