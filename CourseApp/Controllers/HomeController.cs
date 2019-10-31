using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    // localhost:5000
    //localhost:5000/home
    public class HomeController: Controller
    {
        //localhost:5000/home/index => home/index.cshtml
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            ViewBag.Greeting = saat > 12 ? "İyi günler" : "Günaydın";
            ViewBag.UserName = "Mert";
            return View();
        }


        // localhost:5000/home/about => home/about.cshtml
        public IActionResult About()
        {
            return View();
        }

    }
}
