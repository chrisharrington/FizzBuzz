using ConsoleApplication1;
using ConsoleApplication1.Rules;
using ConsoleApplication1.Writer;
using Moq;
using NUnit.Framework;

namespace TestBlah
{
	[TestFixture]
	public class FizzBuzzTest
	{
		private IFizzBuzz _sut;
		private Mock<IWriter> _writer;

		[SetUp]
		public void Setup()
		{
			_writer = new Mock<IWriter>();

			var fizzRule = new Rule(x => x % 3 == 0 ? "Fizz" : "");
			var buzzRule = new Rule(x => x % 5 == 0 ? "Buzz" : "");
			var numberRule = new Rule(x => x % 5 > 0 && x % 3 > 0 ? x.ToString() : "");

			_sut = new FizzBuzz(_writer.Object, fizzRule, buzzRule, numberRule);
		}

		[Test]
		public void ShouldDisplay1With1()
		{
			_sut.Go(1, 1);

			_writer.Verify(x => x.WriteLine("1"));
		}

		[Test]
		public void ShouldDisplayFizzWhenInputDivisibleBy3()
		{
			_sut.Go(3, 3);

			_writer.Verify(x => x.WriteLine("Fizz"));
		}

		[Test]
		public void ShouldDisplayFizzWhenInputDivisibleBy5()
		{
			_sut.Go(5, 5);

			_writer.Verify(x => x.WriteLine("Buzz"));
		}
    }
}
