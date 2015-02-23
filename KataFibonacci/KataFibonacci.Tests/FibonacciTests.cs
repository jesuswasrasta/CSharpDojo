using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;


namespace KataFibonacci.Tests
{
    public class FibonacciTests
    {
		[Test]
		public void Fibonacci_Get_FirstElements_Returns_1()
		{
			const string expectedResult = "1";
			var fibonacci = new Fibonacci();
			var result = fibonacci.GetSequence(1);

			Assert.AreEqual(expectedResult, result);
		}

		[Test]
		public void Fibonacci_Get_First_3_Elements_Returns_112()
		{
			const string expectedResult = "1,1,2";
			var fibonacci = new Fibonacci();
			var result = fibonacci.GetSequence(3);

			Assert.AreEqual(expectedResult, result);
		}

		[Test]
	    public void Fibonacci_Get_First_5_Elements_Returns_11235()
		{
			const string expectedResult = "1,1,2,3,5";
			var fibonacci = new Fibonacci();
			var result = fibonacci.GetSequence(5);

			Assert.AreEqual(expectedResult, result);
		}
    }
}
