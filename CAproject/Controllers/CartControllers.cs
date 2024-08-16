using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using CAproject.Extensions;
using CAproject.Models.Entities;
using Microsoft.EntityFrameworkCore;
using CAproject.Models;

public class CartController : Controller
{
    private const string CartSessionKey = "Cart";
    private readonly VeriTabanıContext = new(); // Veritabanı bağlamınızı kullanın

    public CartController(VeriTabanıContext context )
    {
        context = context;
    }

    [HttpPost]
    public IActionResult AddToCart(int productId)
    {
        var product = context.Products.Find(productId);
        if (product == null)
        {
            return NotFound();
        }

        var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>(CartSessionKey) ?? new List<CartItem>();

        var cartItem = cart.SingleOrDefault(item => item.ProductId == productId);
        if (cartItem != null)
        {
            cartItem.Quantity++;
        }
        else
        {
            cart.Add(new CartItem
            {
                ProductId = product.Id,
                ProductName = product.Ad,
                Image = product.Image,
                Fiyat = product.Fiyat,
                Quantity = 1
            });
        }

        HttpContext.Session.SetObjectAsJson(CartSessionKey, cart);

        return RedirectToAction("Index", "Home");
    }

    public IActionResult Index()
    {
        var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>(CartSessionKey) ?? new List<CartItem>();
        return View(cart);
    }
}
