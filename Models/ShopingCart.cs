using System.Collections;
using System.Collections.Generic;

namespace LanguageFeatures.Models
{
    public class ShopingCart : IProductSelection
    {
        private List<Product>products=new List<Product>();  
        public ShopingCart(params Product[] prods)
        {
            products.AddRange(prods);
        }
        public IEnumerable<Product> Products { get  =>products;  }
    
    }
}
