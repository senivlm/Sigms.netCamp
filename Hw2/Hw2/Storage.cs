using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    class Storage
    {
        public List<Product> Products { get; set; }
        public Storage()
        {
            Products = new List<Product>() {
                new Product("Bread", 15, 0.500),
                new Meat(Sort.Hight,Species.pork,"Meat",120,1.550),
                new Dairy_products(DateTime.Now,30,"DairyProduct",100,1.250)
            };
        }
        public Product this[int index]
        {
            get => Products[index];
            set => Products[index] = value;
        }
        public Storage(params Product[] products)
        {
            Products.AddRange(products);
        }
        public void ShowInfo()
        {
            foreach (var product in Products)
            {
                Console.WriteLine($"{product}");
            }
        }
        public IEnumerable<Meat> GetMeats()
        {
            var meats = Products.OfType<Meat>();
            return meats;
        }
        public void ChangePrices(int percentage)
        {
            Products.ForEach(x => x.ChangePrice(percentage));
        }


    }
}
