using AspMvcDemoProject.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using AspMvcDemoProject.ViewModels;
using AspMvcDemoProject.Models;
using System.Threading.Tasks;

namespace AspMvcDemoProject.Controllers
{
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;

        public OrderController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var orders = _context.Orders.ToList();

            return View(orders);
        }

        public IActionResult GetProdutsWithOrderId(int? id)
        {
            var orderProducts = _context.OrderProducs;
            var products = _context.Products
                .Select(p => new ProductVM
                {
                    Id = p.P_Code,
                    Descript = p.P_descript,
                    Price = p.P_Price,
                    IsActive = orderProducts
                        .Where(op => op.P_Code == p.P_Code && op.OrderId == id)
                        .FirstOrDefault() == null 
                                ? false : true
                });

            SaveProductsVM spvm = new SaveProductsVM
            {
                Products = products.ToList(),
                OrderId = id ?? -1
            };

            return PartialView(spvm);
        }

        public IActionResult SaveProducts(SaveProductsVM obj)
        {
            var remove = _context.OrderProducs
                .Where(op => op.OrderId == obj.OrderId);

            _context.RemoveRange(remove);

            var add = obj.Products
                .Where(p => p.IsActive)
                .Select(op => new OrderProducs
                {
                    OrderId = obj.OrderId,
                    P_Code = op.Id
                });

            _context.AddRange(add);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
