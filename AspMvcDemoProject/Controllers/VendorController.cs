using AspMvcDemoProject.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMvcDemoProject.Controllers
{
    public class VendorController : Controller
    {
        public IActionResult Index()
        {
            var list = MockingRepository.GetVendors();
            return View(list);
        }
    }
}
