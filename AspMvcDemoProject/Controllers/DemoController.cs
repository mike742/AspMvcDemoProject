using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMvcDemoProject.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult CVM()
        {
            return View();
        }

        public IActionResult Index()
        {
            //return "Hello World!!!";
            return View();
        }

        public IActionResult MyAction(int id)
        {
            return Ok($"Has been done successfully with id = {id}"); // 200
        }

        public IActionResult StatusCode()
        {
            // return BadRequest(); // 400 
            // return Unauthorized("Message"); // 401
            // return NotFound(); // 404
            return new UnsupportedMediaTypeResult();
        }

        public IActionResult RedirectResult()
        {
            return Redirect("https://google.com");
        }

        public IActionResult JsonResult()
        {
            return Json(new
            {
                message = "this is a Json result",
                date = DateTime.Now
            });
        }

        public IActionResult ContentResult()
        {
            return Content("Hello! Is a content!");
        }
    }
}
