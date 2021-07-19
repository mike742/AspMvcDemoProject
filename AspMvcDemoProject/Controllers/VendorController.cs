using AspMvcDemoProject.Data;
using AspMvcDemoProject.Models;
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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Vendor obj)
        {
            // add new obj to the collection
            MockingRepository.AddVendor(obj);

            return RedirectToAction("Index");
        }
    }
}
