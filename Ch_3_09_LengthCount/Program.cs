using System;
using System.Collections.Generic;
using System.Linq;

namespace Ch_3_09_LengthCount
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int[] array = { 1, 2, 3 };
			NumberOfElement(array);

			var list = new List<int> { 1, 2, 3 };
			NumberOfElement(list);
		}

		// Length/Count 속성이 아닌 Count 메소드를 사용하여 List 타입과 Array 타입 모두에 대해 동작함
		private static void NumberOfElement<T>(IEnumerable<T> elements)
		{
			Console.WriteLine(elements.Count());
		}
	}
}
