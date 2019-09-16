using System;

namespace _10._Poke_Mon
{
	class Program
	{
		static void Main(string[] args)
		{
			int pokePowerOriginal = int.Parse(Console.ReadLine());
			int reducingPower = int.Parse(Console.ReadLine());
			int exhaustionFactor = int.Parse(Console.ReadLine());

			int pokePower = pokePowerOriginal;

			int counter = 0;

			double halfPower = (50.0 * pokePowerOriginal) / 100;

			while (pokePower >= reducingPower)
			{
				if (halfPower == pokePower)

				//pokePower % exhaustionFactor == 0 &&
				{
					if ( exhaustionFactor != 0)
					{
						pokePower /= exhaustionFactor;
					}
				}

				if (pokePower < reducingPower)
				{
					break;
				}

				pokePower -= reducingPower;
				counter++;

				
			}

			Console.WriteLine(pokePower);
			Console.WriteLine(counter);
		}
	}
}
