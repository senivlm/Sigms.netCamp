using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    class Dairy_products : Product
    {
        public DateTime DateOfManufacture { get; private set; }
        public int DayToExpire { get; private set; }

        public Dairy_products(DateTime dateOfManufacture, int dayToExpire,
            string name, decimal price, double weight) : base(name, price, weight)
        {
            if(dayToExpire<0)
                throw new ArgumentException();

            DateOfManufacture = dateOfManufacture;
            DayToExpire = dayToExpire;
        }
        public bool IsExpired()
        {
            return DateTime.Now > DateOfManufacture.AddDays(DayToExpire);
        }
        public override string ToString()
        {
            return $"name: {Name}, price: {Price}, weight: {Weight}, dateOfManufacture:{DateOfManufacture}, dayToExpire:{DayToExpire}";
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            Dairy_products other = (Dairy_products)obj;

            return (this.Name == other.Name)
                && (this.Price == other.Price)
                && (this.Weight == other.Weight)
                && (this.DateOfManufacture == other.DateOfManufacture)
                && (this.DayToExpire == other.DayToExpire);

        }
        public  void ChangePrice(int percentage,int percentageIsExpired)
        {
            Price = (Price * (decimal)(percentage / 100.0));

            if (IsExpired())
                Price = (Price * (decimal)(percentageIsExpired / 100.0));

        }
    }
}
