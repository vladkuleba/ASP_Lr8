using ASP_Lr8.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASP_Lr8.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { ID = 1, Name = "Product 1", Price = 100M, CreatedDate = DateTime.Now.AddDays(-10) },
                new Product { ID = 2, Name = "Product 2", Price = 150M, CreatedDate = DateTime.Now.AddDays(-5) },
                new Product { ID = 3, Name = "Product 3", Price = 200M, CreatedDate = DateTime.Now.AddDays(-2) },
            };

            return View(products);
        }
    }
}
