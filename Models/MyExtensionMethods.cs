namespace LanguageFeatures.Models
{
    public static class MyExtensionMethods
    {
        public static decimal TotalPrices(this ShopingCart cartParam)//расширяющий метод применяется внутри того же пространства имен, что и класс к которому он применяется
        {
            decimal total = 0;
            foreach(Product prod in cartParam.Products)
            {
                total += prod?.Price ?? 0;
            }
            return total;
        }
    }
}
