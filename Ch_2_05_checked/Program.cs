using System;

namespace Ch_2_05_checked
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			/*
			 * 2로 21번 곱하고 21번 나눴지만 최종 값은 같지 않다.
			 * 21번째 곱샘에서 오버플로우가 발생했기 때문이다. 
			 * 오버플로우 체크의 C#의 기본값은 off다.
			 * 이 기능을 활성화 하려면 checked 블록으로 감싸야 한다.
			 */
			checked
			{
				var a = 1234;
				for (int i = 0; i < 21; i++)
				{
					// 21번째 곱샘에서 오버플로우가 발생
					a *= 2;
					Console.WriteLine("+: " + a);
				}
				for (int i = 0; i < 21; i++)
				{
					a /= 2;
					Console.WriteLine("-: " + a);
				}
				Console.WriteLine(a);
			}
		}
	}
}
