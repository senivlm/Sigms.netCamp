using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    class Meat : Product
    {
        public Meat(Sort meatCategory, Species meatSpecies,
           string name, decimal price, double weight) : base(name, price, weight)
        {
            MeatSpecies = meatSpecies;
            MeatCategory = meatCategory;


        }
        public Sort MeatCategory { get; }
        public Species MeatSpecies { get; }
        public override string ToString()
        {
            return $"name: {Name}, price: {Price}, weight: {Weight}, meatCategory:{MeatCategory}, meatSpecies:{MeatSpecies}";
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            Meat other = (Meat)obj;

            return (this.Name == other.Name)
                && (this.Price == other.Price)
                && (this.Weight == other.Weight)
                && (this.MeatSpecies == other.MeatSpecies)
                && (this.MeatCategory == other.MeatCategory);

        }
        public override void ChangePrice(int percentage)
        {
            Price = (Price * (decimal)(percentage / 100.0));
        }
        public void ChangePrice(int percentage,int percentageHight)
        {
            if (MeatCategory == Sort.Hight)
                percentage += percentageHight;
            
            Price = (Price * (decimal)(percentage / 100.0));
        }



    }
    enum Sort 
    {
        Hight,
        Second
    }
    public enum Species
    {
        mutton,
        veal, 
        pork, 
        chicken
    }
}
