using System.Collections.Generic;
using System;

namespace LanguageFeatures.Models
{
    public static class MyExtensionMethods
    {
        public static decimal TotalPrices(this IEnumerable<Product>products)//расширяющий метод применяется внутри того же пространства имен, что и класс к которому он применяется
        {
            decimal total = 0;
            foreach(Product prod in products)
            {
                total += prod?.Price ?? 0;
            }
            return total;
        }
        public static IEnumerable<Product> Filter(this IEnumerable<Product> productEnum, Func<Product, bool> selektor)
        {
            foreach(Product prod in productEnum)
            {
                if (selektor(prod))
                {
                    yield return prod;
                }
            }
        }
    }
}
