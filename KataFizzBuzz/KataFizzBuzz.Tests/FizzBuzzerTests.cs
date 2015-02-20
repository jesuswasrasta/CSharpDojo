using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;


namespace KataFizzBuzz.Tests
{
	[TestFixture]
    public class FizzBuzzerTests
    {
		[Test]
		public void FizzBuzzer_3_Returns_Fizz()
		{
			const string expected = "Fizz";
			var fizzBuzzer = new FizzBuzzer();
			var result = fizzBuzzer.Say(3);

			Assert.AreEqual(expected, result);
		}
    }
}
