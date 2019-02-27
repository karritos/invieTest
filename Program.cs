using System;

namespace TEST
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("KA");
			SayName("Carlos");
		}

		public static string SayName(string name)
		{
			Console.WriteLine($"hello {name}");
		}
	}
}
