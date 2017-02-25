using System;
using System.IO;

namespace Ch_1_06_dispose
{
	class MainClass
	{

		public static void Main(string[] args)
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

			/*
			 * Write()와 Read()는 별도의 프로그램에서 호출될 경우 문제가 발생하지 않지만
			 * 두 메소드를 하나의 프로세스에서 호출하면 익셉션이 발생한다.
			 * Write() 메소드에서 text.txt를 반환하지 않았기 때문이다.
			Write(folderPath);
			Read(folderPath);
			*/

			WriteAndRead(folderPath);

			using (var gb = new CloseThis())
			{
				// 아무것도 하지 않아도 CloseThis 클래스의 Dispose()가 호출된다.
			}


		}
		static void Write(string folderPath)
		{
			var writer = new StreamWriter(Path.Combine(folderPath, "text.txt"));
			writer.WriteLine("Good morning!");
			writer.Flush();
		}

		static void Read(string folderPath)
		{
			var reader = new StreamReader(Path.Combine(folderPath, "text.txt"));
			Console.WriteLine(reader.ReadToEnd());
		}

		static void WriteAndRead(string folderPath)
		{
			using (var writer = new StreamWriter(Path.Combine(folderPath, "text.txt")))
			{
				writer.WriteLine("Good morning!");
				writer.Flush();
			}

			using (var reader = new StreamReader(Path.Combine(folderPath, "text.txt")))
			{
				Console.WriteLine(reader.ReadToEnd());
			}
		}
	}

	class CloseThis : IDisposable
	{
		public void Dispose()
		{
			Console.WriteLine("Dispose() is called!!");
		}
	}
}
