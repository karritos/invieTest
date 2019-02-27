using System;
using System.IO;

namespace TEST
{
	public class Program
	{
		public static void Main()
		{
			for(int i = 0; i < 10; i++)
			{
				Console.WriteLine("KA");
			}
			SayName("Carlos");
		}

		public static string SayName(string name)
		{
			Console.WriteLine($"hello {name}");
		}
	}
}
