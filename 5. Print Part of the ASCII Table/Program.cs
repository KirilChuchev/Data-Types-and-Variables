using System;

namespace _5._Print_Part_of_the_ASCII_Table
{
	class Program
	{
		static void Main(string[] args)
		{
			int startNumber = int.Parse(Console.ReadLine());
			int endNumber = int.Parse(Console.ReadLine());

			for (int i = startNumber; i <= endNumber; i++)
			{
				Console.Write((char)i + " ");
			}
		}
	}
}
