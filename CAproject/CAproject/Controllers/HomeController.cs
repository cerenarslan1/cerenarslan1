using CAproject.Models;
using CAproject.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CAproject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            VeriTabanıContext context = new();

            List<Product> products = context.Products.ToList();

            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
        
    }
}