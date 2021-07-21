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
        private readonly Mapper _mapper = new Mapper();

        public VendorController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            // var list = _context.Vendors;
            var list = MockingRepository.GetVendors();
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(VendorDto obj)
        {
            Vendor newVendor = _mapper.Map(obj);
            MockingRepository.AddVendor(newVendor);

            return RedirectToAction("Index");
        }
    }
}
