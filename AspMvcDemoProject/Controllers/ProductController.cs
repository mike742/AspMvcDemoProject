using Microsoft.AspNetCore.Mvc;
using AspMvcDemoProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspMvcDemoProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AspMvcDemoProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var list = _context.Products.Include(p => p.Vendor);

            return View(list);
        }

        public IActionResult GetProdutsByVendorCode(int? id)
        {
            var products = _context.Products
                .Where(p => p.V_code == id)
                .Select(e => e.P_descript);

            if (products.Count() == 0)
            {
                return Content("No Products found");
            }

            return Content(string.Join("<br>", products));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Vendors = 
                new SelectList(_context.Vendors, "V_code", "V_name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product obj)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(obj);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            ViewBag.Vendors =
                new SelectList(_context.Vendors, "V_code", "V_name");
            return View(obj);
        }
    }
}
