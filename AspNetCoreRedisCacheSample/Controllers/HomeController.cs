using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreRedisCacheSample.Infrastracture.FilterAttribute;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreRedisCacheSample.Models;

namespace AspNetCoreRedisCacheSample.Controllers
{
    public class HomeController : Controller
    {
        [Cache(Duration = 30)]
        public IActionResult Index()
        {
            return View();
        }

        [Cache(Duration = 86400)]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [Cache(Duration = 86400)]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [Cache(Duration = 86400)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
