using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace My_Website.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Default()
        {
            return View();
        }

        public ActionResult News()
        {
            return View();
        }
    }
}