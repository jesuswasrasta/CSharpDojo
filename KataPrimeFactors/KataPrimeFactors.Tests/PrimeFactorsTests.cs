using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit;
using NUnit.Framework;


namespace KataPrimeFactors.Tests
{
	public class PrimeFactorsTests
    {
		[TestCase(0, new[] { 0 })]
		[TestCase(1, new[] { 1 })]
		[TestCase(2, new[] { 2 })]
		[TestCase(3, new[] { 3 })]
		[TestCase(4, new[] { 2 })]
		[TestCase(5, new[] { 5 })]
		[TestCase(6, new[] { 3, 2 })]
		[TestCase(7, new[] { 7 })]
		[TestCase(8, new[] { 2 })]
		[TestCase(9, new[] { 3 })]
		[TestCase(10, new[] { 5, 2 })]
		[TestCase(11, new[] { 11 })]
		[TestCase(12, new[] { 3, 2 })]
		[TestCase(13, new[] { 13 })]
		public void PrimeFactors_1_Retursn_1(int number, int[] expectedFactors)
		{
			var primeFactors = new PrimeFactors();
			var factors = primeFactors.Get(number);

			Assert.IsTrue(expectedFactors.SequenceEqual(factors));
		}
    }
}
