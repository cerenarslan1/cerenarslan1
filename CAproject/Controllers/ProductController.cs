using CAproject.Models;
using CAproject.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CAproject.Controllers
{
    public class ProductController:Controller
    {
        VeriTabanıContext _context = new();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListeleBileklik()
        {
            List<Product> urunler = _context.Products.ToList();
            return View(urunler);
        }
        public IActionResult ListeleYuzuk()
        {
            List<Product> urunler = _context.Products.ToList();
            return View(urunler);
        }
        public IActionResult ListeleKolye()
        {
            List<Product> urunler = _context.Products.ToList();
            return View(urunler);
        }
        public IActionResult ListeleKupe()
        {
            List<Product> urunler = _context.Products.ToList();
            return View(urunler);
        }
        public IActionResult SepetEkle()
        {
            List<Product> urunler = _context.Products.ToList();
            return View(urunler);
        }



    }
}
