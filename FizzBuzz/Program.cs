using System.Security.Cryptography.X509Certificates;
using ConsoleApplication1.Rules;
using ConsoleApplication1.Writer;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			var writer = new ConsoleWriter();

			var fizzRule = new Rule(x => x%3 == 0 ? "Fizz" : "");
			var buzzRule = new Rule(x => x%5 == 0 ? "Buzz" : "");
			var numberRule = new Rule(x => x%5 > 0 && x%3 > 0 ? x.ToString() : "");

			new FizzBuzz(writer, fizzRule, buzzRule, numberRule).Go(1, 100);
		}
	}
}
