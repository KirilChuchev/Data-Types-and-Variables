using System;

namespace _06._Triples_of_Latin_Letters
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());

			char endLetter = (char)(number + 97 - 1);

			for (char i = 'a'; i <= endLetter; i++)
			{
				for (char j = 'a'; j <= endLetter; j++)
				{
					for (char g = 'a'; g <= endLetter; g++)
					{
						Console.WriteLine($"{i}{j}{g}");
					}
				}
			}
		}
	}
}
