using System;

namespace _1._Integer_Operations
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberOne = int.Parse(Console.ReadLine());
			int numberTwo = int.Parse(Console.ReadLine());
			int numberThree = int.Parse(Console.ReadLine());
			int numberFour = int.Parse(Console.ReadLine());

			int sum = (numberOne + numberTwo) / numberThree * numberFour;

			Console.WriteLine(sum);
		}
	}
}
