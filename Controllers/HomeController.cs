using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {
            ShopingCart cart = new ShopingCart { Products = Product.GetProducts() };
            Product[] productArray =
            {
                new Product{Name="Kayak",Price=275M},
                new Product{Name="Lifejacket",Price=48.95M}
            };
            decimal cartTotal = cart.TotalPrices();
            decimal arraytotal = productArray.TotalPrices();
            return View("Index", new string[]
            {
                $"Cart Total: {cartTotal:C2}",
                $"Array Total: {arraytotal:C2}"
            });
        }
    }
}
