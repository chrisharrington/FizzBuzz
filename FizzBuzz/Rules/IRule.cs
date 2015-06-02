using System;

namespace ConsoleApplication1.Rules
{
	public interface IRule
	{
		string Execute(int value);
	}
}