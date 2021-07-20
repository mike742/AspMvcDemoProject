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
        private readonly AppDbContext _context;

        public VendorController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var list = _context.Vendors;
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
