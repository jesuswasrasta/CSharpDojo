using NUnit.Framework;


namespace KataFibonacci.Tests
{
    public class FibonacciTests
    {
		[TestCase(-1, "")]
		[TestCase(0,"")]
		[TestCase(1, "1")]
		[TestCase(2, "1,1")]
		[TestCase(3, "1,1,2")]
		[TestCase(4, "1,1,2,3")]
		[TestCase(5, "1,1,2,3,5")]
		[TestCase(6, "1,1,2,3,5,8")]
		[TestCase(7, "1,1,2,3,5,8,13")]
	    public void Fibonacci_Get_First_5_Elements_Returns_11235(int numberOfElements, string expectedResult)
		{
			var fibonacci = new Fibonacci();
			var result = fibonacci.GetSequence(numberOfElements);

			Assert.AreEqual(expectedResult, result);
		}
    }
}
