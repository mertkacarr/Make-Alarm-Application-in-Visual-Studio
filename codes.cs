using System;

namespace ConsoleApp2
{
	class Program
	{
		static void Main()
		{
			int minute; 
			int miliSecond;

			Console.WriteLine("ALARM APPLİCATİON");
			Console.Write("How many minutes will you sleep? ");
			minute = Convert.ToInt32(Console.ReadLine());

			miliSecond = minute * 60 * 1000;

			System.Threading.Thread.Sleep(miliSecond);

			System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
			{
				FileName = "https://www.youtube.com/watch?v=WI9EbuLX1FY",
				UseShellExecute = true
			});

		}
	}
}
