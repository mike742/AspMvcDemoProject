using Microsoft.AspNetCore.Mvc;
using AspMvcDemoProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspMvcDemoProject.Models;

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

        public IActionResult GetProdutsByVendorCode(int? code)
        {
            var products = MockingRepository.GetProducs()
                .Where(p => p.V_code == code)
                .Select(e => e.P_descript);

            return Content(string.Join("<br>", products));
        }
    }
}
