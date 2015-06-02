using System;

namespace ConsoleApplication1.Writer
{
	public class ConsoleWriter : IWriter
	{
		public void WriteLine(string message)
		{
			Console.WriteLine(message);
		}
	}
}