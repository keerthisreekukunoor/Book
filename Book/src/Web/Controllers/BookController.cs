using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class BookController : Controller
    {
       
        public IActionResult Text()
        {
            return Content("This is the text view of book");
        }

          public IActionResult JSON()
        {
            return Json(new { name="JSON",description="this "});
        }
         public IActionResult HTML()
        {
            return Content("<html><body><h1>This is HTML method</h1></body></html>","text/html");
        }
        public IActionResult ViewPage()
        {
            return View();
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
