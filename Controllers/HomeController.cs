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
                new Product{Name="Lifejacket",Price=48.95M},
                new Product{Name="Soccer ball", Price=19.50M},
                new Product{Name="Corner flag", Price=34.95M}
            };
            decimal arraytotal = productArray.FilterByPrice(20).TotalPrices();
            return View("Index", new string[]
            {
                $"Array Total: {arraytotal:C2}"
            });
        }
    }
}
