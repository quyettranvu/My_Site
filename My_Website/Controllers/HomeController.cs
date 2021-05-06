using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using My_Website.Models;

namespace My_Website.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Trang mo ta thong tin cua ban.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Trang thong tin lien lac cua ban tren About.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //Tao them 1 muc nua tren Home
        public IActionResult Product()
        {
            ViewBag.view = "Day la trang san pham cua ban";
            return View();
        }
    }
}
