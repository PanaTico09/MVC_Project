using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Nums()
        {
            int min = 1;
            int max = 15;
            ViewBag.min = "The min num is: " + min.ToString();
            ViewBag.max = "The max num is: " + max.ToString();
            ViewBag.num = "The random number is: " + RanNum(min, max).ToString();
            return View();
        }

        public int RanNum(int min, int max)
        {
            return new Random().Next(min, max);
        }
    }
}