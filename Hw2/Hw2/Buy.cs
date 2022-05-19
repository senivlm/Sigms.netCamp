using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    class Buy
    {
        public Buy(Product product, int count)
        {
            if (product==null || count <= 0)
                throw new ArgumentException();
            _product = product;
            _count = count;
            _totalPrice = product.Price * _count;
            _totalWeight = product.Weight * _count;
        }
        private Product _product;
        public string Product { get=> _product.ToString();}

        private int _count;

        private double _totalWeight;
        public double TotalWeight { get => _totalWeight; }

        private decimal _totalPrice;
        public decimal TotalPrice { get => _totalPrice; }
        public override string ToString()
        {
            return $"Product: {Product}, Count:{_count}, TotalPrice: {_totalPrice}, TotalWeight: {_totalWeight}";
        }

    }
}
