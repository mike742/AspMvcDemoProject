using Microsoft.AspNetCore.Mvc;
using AspMvcDemoProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMvcDemoProject.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var list = MockingRepository.GetProducs();
            return View(list);
        }
    }
}
