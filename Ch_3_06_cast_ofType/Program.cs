using System;
using System.Linq;

namespace Ch_3_06_cast_ofType
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			object[] ary = { 1, "a", 3 };
			Console.WriteLine(ary.Select(c => (int)c).Sum()); // Exception

			object[] ary2 = { 1, "a", 3 };
			var q = ary2.Cast<int>();
			Console.WriteLine(q.Sum()); // Exception

			object[] ary3 = { 1, "a", 3 };
			var q3 = ary3.OfType<int>();
			Console.WriteLine(q3.Sum());
		}
	}
}
