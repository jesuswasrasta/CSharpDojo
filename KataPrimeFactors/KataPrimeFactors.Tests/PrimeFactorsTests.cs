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
		[Test]
		public void PrimeFactors_1_Retursn_1()
		{
			const int expectedFactor = 1;

			var primeFactors = new PrimeFactors();
			var factors = primeFactors.Get(1);

			Assert.AreEqual(expectedFactor, factors[0]);
		}
    }
}
