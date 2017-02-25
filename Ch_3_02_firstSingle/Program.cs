using System;
using System.Linq;

namespace Ch_3_02_firstSingle
{
	class MainClass
	{
		static void FirstOrSingle_1()
		{
			var s = "Hello World*";
			Console.WriteLine("Contained punctuation is [{0}]."
							  , s.First(c => char.IsPunctuation(c)));
			Console.WriteLine("Contained punctuation is [{0}]."
							  , s.Single(c => char.IsPunctuation(c)));
		}

		static void FirstOrSingle_2()
		{
			var enumObj = Enumerable.Range(0, 1000000000);

			// 전체 요소 중 10개까지만 탐색하면 되기 때문에 금방 끝난다
			var start_1 = DateTime.Now;
			var a = enumObj.First(c1 => c1 == 10);
			Console.WriteLine(DateTime.Now - start_1);

			// 999999990번째 요소까지 탐색해야 하기 때문에 오래 걸린다
			var start_2 = DateTime.Now;
			var b = enumObj.First(c2 => c2 == 999999990);
			Console.WriteLine(DateTime.Now - start_2);

			// 모든 요소를 탐색해야 하기 대문에 오래 걸린다
			var start_3 = DateTime.Now;
			var c = enumObj.Single(c3 => c3 == 10);
			Console.WriteLine(DateTime.Now - start_3);

			// 모든 요소를 탐색해야 하기 대문에 오래 걸린다
			var start_4 = DateTime.Now;
			var d = enumObj.Single(c4 => c4 == 999999990);
			Console.WriteLine(DateTime.Now - start_4);
		}

		public static void Main(string[] args)
		{
			FirstOrSingle_1();
			FirstOrSingle_2();
		}
	}
}
