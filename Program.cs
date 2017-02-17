using System;

namespace ReverseString
{
	public class MainClass
	{
		public static void Main()
		{
			var getString = Console.ReadLine();

			char[] reverse = getString.ToCharArray();
			Array.Reverse(reverse);

			Console.WriteLine(new string(reverse));
		}
	}
}
