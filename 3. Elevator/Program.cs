using System;

namespace _3._Elevator
{
	class Program
	{
		static void Main(string[] args)
		{
			int persons = int.Parse(Console.ReadLine());
			int capacity = int.Parse(Console.ReadLine());

			decimal courses = Math.Ceiling(persons * 1.0m / capacity);

			Console.WriteLine(courses);
		}
	}
}
