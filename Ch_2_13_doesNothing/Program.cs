using System;

namespace Ch_2_13_doesNothing
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			IReportBase[] reportAry = { new NoReport()
									  , new ConsoleReport() };

			foreach (var report in reportAry)
			{
				report.Outout("Hello World!");
			}
		}
	}

	class NoReport : IReportBase
	{
		public void Outout(string s)
		{
		}
	}

	class ConsoleReport : IReportBase
	{
		public void Outout(string s)
		{
			Console.WriteLine(s);
		}
	}

	interface IReportBase
	{
		void Outout(string s);
	}
}
