using System;

namespace ConsoleApp1
{
	using System.Numerics;

	class Program
	{
		static void Main(string[] args)
		{
			uint number = uint.Parse(Console.ReadLine());

			uint snowballSnow = 0;
			uint snowballSnowMax = 0;
			uint snowballTime = 0;
			uint snowballTimeMax = 0;
			uint snowballQuality = 0;
			uint snowballQualityMax = 0;




			BigInteger snowballValue = 0;
			BigInteger snowballValueCurrent = 0;
			BigInteger snowballValueMax = 0;

			

			for (uint i = 1; i <= number; i++)
			{
				snowballSnow = uint.Parse(Console.ReadLine());
				snowballTime = uint.Parse(Console.ReadLine());
				snowballQuality = uint.Parse(Console.ReadLine());

				snowballValueCurrent = (snowballSnow / snowballTime);
				snowballValue = snowballValueCurrent;

				for (int j = 1; j < snowballQuality; j++)
				{
					snowballValue *= snowballValueCurrent;
				}

				if (snowballQuality == 0)
				{
					snowballValue = 1;
				}
				

				if (snowballValue >= snowballValueMax)
				{
					snowballValueMax = snowballValue;
					snowballSnowMax = snowballSnow;
					snowballTimeMax = snowballTime;
					snowballQualityMax = snowballQuality;
				}
			}


			if (number > 0)
			{
				

			}

			Console.WriteLine($"{snowballSnowMax} : {snowballTimeMax} = {snowballValueMax} ({snowballQualityMax})");
		}
	}
}
