﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;
using System;
using System.Linq;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            IProductSelection cart=new ShopingCart
            (
                new Product{Name="Kayak",Price=275M},
                new Product{Name="Lifejacket",Price=48.95M},
                new Product{Name="Soccer ball",Price=19.50M},
                new Product{Name="Corner flag",Price=34.95M}
            );
            return View(cart.Products.Select(p=>p.Name));
        }
    }
}
