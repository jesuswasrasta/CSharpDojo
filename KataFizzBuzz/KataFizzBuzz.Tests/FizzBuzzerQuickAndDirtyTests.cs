using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;


namespace KataFizzBuzz.Tests
{
	[TestFixture]
    public class FizzBuzzerQuickAndDirtyTests
    {
		[TestCase(3)]
		[TestCase(6)]
		[TestCase(12)]
		[TestCase(27)]
		public void FizzBuzzer_Multiple_Of_3_Returns_Fizz(int number)
		{
			const string expected = "Fizz";
			var fizzBuzzer = new FizzBuzzerQuickAndDirty();
			var result = fizzBuzzer.Say(number);

			Assert.AreEqual(expected, result);
		}

		[TestCase(5)]
		[TestCase(10)]
		[TestCase(645)]
		[TestCase(35)]
		public void FizzBuzzer_5_Returns_Fizz(int number)
		{
			const string expected = "Buzz";
			var fizzBuzzer = new FizzBuzzerQuickAndDirty();
			var result = fizzBuzzer.Say(5);

			Assert.AreEqual(expected, result);
		}

		[TestCase(15)]
		[TestCase(30)]
		[TestCase(150)]
		[TestCase(90)]
		public void FizzBuzzer_15_Returns_FizzBuzz(int number)
		{
			const string expected = "FizzBuzz";
			var fizzBuzzer = new FizzBuzzerQuickAndDirty();
			var result = fizzBuzzer.Say(15);

			Assert.AreEqual(expected, result);
		}
    }
}
