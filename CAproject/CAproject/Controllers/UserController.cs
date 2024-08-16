using CAproject.Models.Entities;
using CAproject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CAproject.Controllers
{
    public class UserController : Controller
    {
        VeriTabanıContext _context = new();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult UyeOl()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UyeOl(User user)
        {
            User user1 = new()
            {
                Ad = user.Ad,
                Soyad = user.Soyad,
                Sifre = user.Sifre,
                Mail = user.Mail
            };
            _context.Add(user1);
            _context.SaveChanges();
            return View();
        }



        public IActionResult GirisYap()
        {
            return View();
        }


        [HttpPost]
        public IActionResult GirisYap(User user)
        {
            User usergiris = _context.Users.FirstOrDefault(k => k.Mail == user.Mail);

            if (usergiris != null)
            {
                if (usergiris.Sifre == user.Sifre)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
        public IActionResult SepetEkle()
        {
            return View();
        }


    }
}