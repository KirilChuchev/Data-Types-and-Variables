using System;

namespace _8._Beer_Kegs
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());

			double maxVolume = 0;
			string maxType = string.Empty;

			for (int i = 1; i <= number; i++)
			{
				string type = Console.ReadLine();
				double radius = double.Parse(Console.ReadLine());
				int height = int.Parse(Console.ReadLine());

				double volume = Math.PI * Math.Pow(radius, 2) * height;

				if (volume >= maxVolume)
				{
					maxVolume = volume;
					maxType = type;
				}



			}

			Console.WriteLine(maxType);
		}
	}
}
