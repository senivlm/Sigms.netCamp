using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hw2
{
	public class Product
	{
		private string _name;
		public string Name 
		{
			get=> _name;
			set
			{
				if (string.IsNullOrWhiteSpace(_name))
					throw new ArgumentException();
				_name = value;
			}
		}

		private decimal _price;
		public decimal Price
		{
			get=> _price;
			
			set
			{
				if (_price < 0)
					throw new ArgumentException();
				_price = value;
			}
		}

		private double _weight;
		public double Weight
		{
			get => _weight;
			set
			{
				if (_weight < 0)
					throw new ArgumentException();
				_weight = value;
			}
		}

		public Product() : this(null, default, default)
		{

		}

		public Product(string name, decimal price, double weight)
		{
			if (price < 0 || weight < 0|| string.IsNullOrWhiteSpace(name))
				throw new ArgumentException();
			_name = name;
			_price = price;
			_weight = weight;
		}

		public override string ToString()
		{
			return $"name: {_name}, price: {_price}, weight: {_weight}";
		}
		public virtual void ChangePrice(int percentage)
		{
			Price = (Price * (decimal)(percentage / 100.0));
		}

		public void Parse(string product)
		{
			var regex = new Regex("^\\w+ [0-9]*([.,][0-9]{1,2}) [0-9]*([.,][0-9]{1,3})?$"); 

			if (!regex.IsMatch(product))
				throw new ArgumentNullException();

			string[] arrayString = product.Split(' ');
			Name = arrayString[0];
			Price = decimal.Parse(arrayString[1]);

			if (!double.TryParse(arrayString[2], out _weight))
				throw new ArgumentException();
		}


	}
}
