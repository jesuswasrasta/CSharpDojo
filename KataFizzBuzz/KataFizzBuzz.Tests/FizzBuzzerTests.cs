using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;


namespace KataFizzBuzz.Tests
{
	[TestFixture]
    public class FizzBuzzerTests
    {
		[TestCase(1, "1")]
		[TestCase(2, "2")]
		[TestCase(3, "Fizz")]
		[TestCase(12, "Fizz")]
		[TestCase(5, "Buzz")]
		[TestCase(10, "Buzz")]
		[TestCase(15, "FizzBuzz")]
		[TestCase(90, "FizzBuzz")]
		public void FizzBuzzer_TheUltimateTest(int number, string expectedString)
		{
			var fizzBuzzer = new FizzBuzzer();
			fizzBuzzer.AddRule(new MultipleOf3Rule());
			fizzBuzzer.AddRule(new MultipleOf5Rule());
			fizzBuzzer.AddRule(new MultipleOf15Rule());

			var result = fizzBuzzer.Say(number);

			Assert.AreEqual(expectedString, result);
		}
    }
}
