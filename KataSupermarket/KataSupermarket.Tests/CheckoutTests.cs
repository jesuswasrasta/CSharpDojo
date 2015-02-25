using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;


namespace KataSupermarket.Tests
{
	[TestFixture]
    public class CheckoutTests
    {
		[Test]
		public void Checkout_ProductA_Returns_50()
		{
			var checkout = new Checkout();
			var price = checkout.GetPrice("A");
			double expectedPrice = 50;
		
			Assert.AreEqual(expectedPrice, price);
		}
    }
}
