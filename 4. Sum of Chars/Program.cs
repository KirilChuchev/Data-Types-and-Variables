using System;

namespace _4._Sum_of_Chars
{
	class Program
	{
		static void Main(string[] args)
		{
			ushort number = ushort.Parse(Console.ReadLine());
			

			int sum = 0;

			for (int i = 0; i < number; i++)
			{
				char letter = char.Parse(Console.ReadLine());
				sum += (int)letter;
			}

			Console.WriteLine($"The sum equals: {sum}");
		}
	}
}
