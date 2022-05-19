using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var bread = new Product("Bread",(decimal)1.99,0.999);
            var buy = new Buy(bread, 3);
            Check.Show(buy);
        }
    }
}
