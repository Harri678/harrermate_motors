namespace Motors
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Statisztika statisztika = new Statisztika();
			statisztika.ReadFromFile("C:\\Users\\Diák\\source\\repos\\Motors\\Motors\\bin\\Debug\\net8.0\\motors.txt");

			Console.WriteLine("SumPrices: " + statisztika.SumPrices());
			Console.WriteLine("Contains: " + statisztika.Contains("Yamaha YZF-R1"));
			Console.WriteLine("Oldest" + statisztika.Oldest());
			Console.WriteLine("SumBrand: " + statisztika.SumBasedOnBrand("Yamaha"));
			statisztika.Sort();

        }
	}
}
