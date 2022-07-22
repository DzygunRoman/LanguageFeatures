using System.Collections;
using System.Collections.Generic;

namespace LanguageFeatures.Models
{
    public class ShopingCart:IEnumerable<Product>//оболочка для последовательности объектов Product
    {
        public IEnumerable<Product>Products { get; set; }
        public IEnumerator<Product> GetEnumerator()
        {
            return Products.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
