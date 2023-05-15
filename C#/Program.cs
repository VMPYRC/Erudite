using System;

namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			char x = 'x'; // character
			Console.WriteLine(x);

			String delicious = " is delicious."; // string
			string food = "Takoyaki";
			Console.WriteLine(food + delicious);
			food = "Onigiri"; // changed value
			Console.WriteLine(food + delicious);

			bool trueBool = true; // boolean

			int one = 1; // integer, whole number
			int two; // declared
			two = 2; // assigned later
			const int three = 3; // const = unchangeable
			int four = 4, five = 5, six = 6;
			int sevn, svn, seven;
			sevn = svn = seven = 7;
			Console.WriteLine(one + two + three + four + five + six);
			Console.WriteLine(sevn + svn + seven);

			double eightTwelve = 8.12D; // floating point number
			Console.WriteLine(eightTwelve);


		}
	}
}