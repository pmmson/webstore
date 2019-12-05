using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Domain.Entities;
using WebStore.Infrastructure.Interfaces;
using WebStore.Models;
using WebStore.Models.Product;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index([FromServices] IProductData _productData)
        {
            return View(new CatalogViewModel
            {
                Products = _productData.GetProducts(new ProductFilter()).Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    ImageUrl = p.ImageUrl,
                    Name = p.Name,
                    Order = p.Order,
                    Price = p.Price
                })
            });
        }
        public IActionResult Blog() => View();

        public IActionResult BlogSingle() => View();
                
        public IActionResult CheckOut() => View();

        public IActionResult Error404() => View();

        public IActionResult ContactUs() => View();
    }
}