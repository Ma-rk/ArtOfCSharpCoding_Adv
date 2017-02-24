using System;
using System.IO;
using System.Threading.Tasks;

namespace Ch_1_05_async
{
	class MainClass
	{
		const string HELLO = "hello!";
		const string WORLD = "World!";

		static void Async_1()
		{
			Console.WriteLine("begin Async_1:");
			File.WriteAllText("text1.txt", HELLO);
			StreamReader reader = File.OpenText("text1.txt");
			Task<string> task1 = reader.ReadToEndAsync();
			Task task2 = Task.Run(() =>
			{
				Console.WriteLine(WORLD);
			});
			Task.WaitAll(task1, task2);
			Console.WriteLine(task1.Result);
			reader.Close();
			Console.WriteLine("end Async_1...\n\n");
		}

		static void Async_2()
		{
			Console.WriteLine("begin Async_2:");
			File.WriteAllText("text3.txt", HELLO);
			StreamReader reader = File.OpenText("text3.txt");
			Task<string> task = reader.ReadToEndAsync();
			Console.WriteLine(WORLD);
			Console.WriteLine(task.Result);
			reader.Close();
			Console.WriteLine("end Async_2...\n\n");
		}

		static void Async_3()
		{
			Console.WriteLine("begin Async_3:");
			File.WriteAllText("text4.txt", HELLO);
			StreamReader reader = File.OpenText("text4.txt");
			Task<string> task1 = reader.ReadToEndAsync();
			Task task2 = Console.Out.WriteLineAsync(WORLD);
			Task task3 = Console.Out.WriteLineAsync(task1.Result);
			Task.WaitAll(task2, task3);
			reader.Close();
			Console.WriteLine("end Async_3...\n\n");
		}

		static void Parallel_1()
		{
			Console.WriteLine("begin Parallel_1:");
			File.WriteAllText("text2.txt", HELLO);
			StreamReader reader = File.OpenText("text2.txt");
			Parallel.Invoke(
			() =>
			{
				Console.WriteLine(reader.ReadToEnd());
			},
			() =>
			{
				Console.WriteLine(WORLD);
			});
			reader.Close();
			Console.WriteLine("end Parallel_1...\n\n");
		}

		public static void Main(string[] args)
		{
			Async_1();
			Async_2();
			Async_3();
			Parallel_1();
		}
	}
}
