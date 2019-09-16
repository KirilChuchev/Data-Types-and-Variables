using System;

namespace _7._Water_Overflow
{
	class Program
	{
		static void Main(string[] args)
		{
			int capacity = 255;
			int volume = 0;

			int number = int.Parse(Console.ReadLine());
			

			for (int i = 1; i <= number; i++)
			{
				int quantity = int.Parse(Console.ReadLine());

				if (quantity > capacity)
				{
					Console.WriteLine("Insufficient capacity!");
				}
				else
				{
					capacity -= quantity;
					volume += quantity;
				}

			}

			Console.WriteLine(volume);
		}
	}
}
