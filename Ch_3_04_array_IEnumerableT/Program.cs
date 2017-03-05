using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Ch_3_04_array_IEnumerableT
{
	class MainClass
	{
		const int SIZE = 1000000;
		const int COUNT = 100000000;
		static int n = 0;

		public static void Main(string[] args)
		{
			int[] ary = new int[SIZE];
			ary[SIZE - 1] = 987;

			Stopwatch sw = new Stopwatch();

			sw.Start();

			for (int i = 0; i < COUNT; i++)
				n = ary.ElementAtOrDefault(SIZE - 1);

			sw.Stop();
			Console.WriteLine(sw.Elapsed);

			sw.Reset();
			sw.Start();

			for (int i = 0; i < COUNT; i++)
				n = ary[SIZE - 1];

			sw.Stop();
			Console.WriteLine(sw.Elapsed);

			sw.Reset();
			sw.Start();

			var q = EnumSample();
			var r1 = q.First();

			sw.Stop();
			Console.WriteLine(sw.Elapsed);


			sw.Reset();
			sw.Start();

			var ar = EnumSample().ToArray();
			var r2 = ar[0];

			sw.Stop();
			Console.WriteLine(sw.Elapsed);
		}

		private static IEnumerable<int> EnumSample()
		{
			yield return 1;
			yield return 2;
		}
	}
}
