using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreSample
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string[] days = new string []{ "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            ViewBag.Days = days;
            return View();
        }
    }
}
