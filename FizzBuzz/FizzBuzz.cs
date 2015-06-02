using System;
using System.Linq;
using ConsoleApplication1.Rules;
using ConsoleApplication1.Writer;

namespace ConsoleApplication1
{
	public class FizzBuzz : IFizzBuzz
	{
		private readonly IWriter _writer;
		private readonly IRule[] _rules;

		public FizzBuzz(IWriter writer, params IRule[] rules)
		{
			if (writer == null)
				throw new ArgumentNullException("writer");

			_writer = writer;
			_rules = rules;
		}

		public void Go(int min, int max)
		{
			// 3 - fizz
			// 5 - buzz
			// both - fizzbuzz
			// else number

			for (var i = min; i <= max; i++)
			{
				_writer.WriteLine(String.Join("", _rules.Select(x => x.Execute(i))));

//				if (i%3 == 0)
//					str += "Fizz";
//				if (i%5 == 0)
//					str += "Buzz";
//				if (i%3 > 0 && i%5 > 0)
//					str += i.ToString();
				//_writer.WriteLine(str);
			}
		}
	}
}
