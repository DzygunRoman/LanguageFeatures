using System.Collections.Generic;

namespace LanguageFeatures.Models
{
    public class ShopingCart//оболочка для последовательности объектов Product
    {
        public IEnumerable<Product>Products { get; set; }
    }
}
