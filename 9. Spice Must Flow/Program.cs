using System;

namespace _9._Spice_Must_Flow
{
	class Program
	{
		static void Main(string[] args)
		{
			int startingYield = int.Parse(Console.ReadLine());

			int currentYield = startingYield;
			int dayCounter = 0;
			int leaving = 0;
			int leavingTotal = 0;

			while ((currentYield) >= 100)
			{
				
				leaving = currentYield - 26;
				leavingTotal += leaving;
				dayCounter++;
				currentYield -= 10;


			}

			if (startingYield < 100)
			{
				Console.WriteLine(dayCounter);
				Console.WriteLine(leavingTotal);
			}
			else
			{
				Console.WriteLine(dayCounter);
				Console.WriteLine(leavingTotal - 26);
			}
			
		}
	}
}
