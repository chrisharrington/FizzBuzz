using System;

namespace ConsoleApplication1.Rules
{
	public class Rule : IRule
	{
		private readonly Func<int, string> _func;

		public Rule(Func<int, string> func)
		{
			if (func == null)
				throw new ArgumentNullException("rule");

			_func = func;
		}

		public string Execute(int value)
		{
			return _func.Invoke(value);
		}
	}
}