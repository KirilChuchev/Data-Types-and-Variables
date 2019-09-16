using System;

namespace test
{
	using System.Numerics;

	class Program
	{
		static void Main(string[] args)
		{
			
			int n = 100;
			BigInteger number = n;

			for (int i = 1; i <= 1000; i++)
			{
				number *= n;
			}

			Console.WriteLine(number);
			Console.WriteLine(Math.Pow(0,5));

			Console.WriteLine(n / 0);
		}
	}
}
