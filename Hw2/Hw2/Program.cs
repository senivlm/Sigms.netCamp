using System;

namespace Hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product("Bread", 15, 0.500);
            var buy = new Buy(product, 5);
            Check.Show(buy);
            var storage = new Storage();
            storage.ShowInfo();

            var meats = storage.GetMeats();
            storage.ChangePrices(110);
            storage.ShowInfo();

            var meat = new Meat(Sort.Hight, Species.pork, "Meat", (decimal)12.02 , 3.181);
            var dairyProduct = new Dairy_products(DateTime.Now, 45, "DairyProduct", 120, 158);

            var isProduct = product.Equals(storage[0]);
            var isMeat = meat.Equals(storage[1]);
            var isDairyProduct = dairyProduct.Equals(storage[2]);
        }
    }
}
