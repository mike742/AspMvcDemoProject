using Microsoft.AspNetCore.Mvc;
using AspMvcDemoProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspMvcDemoProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspMvcDemoProject.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var vendors = MockingRepository.GetVendors();

            var list = MockingRepository.GetProducs()
                .Select(p =>
                {
                    p.Vendor = vendors
                     .Where(v => v.V_code == p.V_code)
                     .FirstOrDefault() ?? new Vendor { V_name = "n/a" };
                    return p;
                });

            /*
            foreach (var item in list)
            {
                var vendor = vendors
                    .Where(v => v.V_code == item.V_code)
                    .FirstOrDefault() ?? new Models.Vendor { V_name = "N/A ??" }; ;

                //if (vendor == null)
                //{
                //    vendor = new Models.Vendor { V_name = "N/A" };
                //}

                item.Vendor = vendor;
            }
            */

            return View(list);
        }

        public IActionResult GetProdutsByVendorCode(int? id)
        {
            var products = MockingRepository.GetProducs()
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
                new SelectList(MockingRepository.GetVendors(), "V_code", "V_name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product obj)
        {
            MockingRepository.AddProduct(obj);

            return RedirectToAction("Index");
        }
    }
}
