using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motors
{
	internal class Motor
	{
		string brand;
		string name;
		int releaseYear;
		double performance;
		double priceInEur;

		public Motor(string brand, string name, int releaseYear, double performance, double priceInEur)
		{
			this.brand = brand;
			this.name = name;
			this.releaseYear = releaseYear;
			this.performance = performance;
			this.priceInEur = priceInEur;
		}

		public string Brand { get => brand; set => brand = value; }
		public string Name { get => name; set => name = value; }
		public int ReleaseYear { get => releaseYear; set => releaseYear = value; }
		public double Performance { get => performance; set => performance = value; }
		public double PriceInEur { get => priceInEur; set => priceInEur = value; }

		public override string ToString()
		{
			return $"{Name} ({Brand}), {ReleaseYear}, {Performance} HP, {PriceInEur} EUR";
		}
	}
}
