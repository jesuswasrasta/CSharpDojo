using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

using Moq;

using NUnit.Framework;


namespace KataSupermarket.Tests
{
	[TestFixture]
    public class CheckoutTests
    {
		private List<IProductRule> _productRules;

		[SetUp]
		public void Setup()
		{
			var productRuleA1 = new ProductRule();
			productRuleA1.Set('A', 1, 50);
			
			var productRuleA3 = new ProductRule();
			productRuleA3.Set('A', 3, 130);

			var productRuleB1 = new ProductRule();
			productRuleB1.Set('B', 1, 30);

			var productRuleB2 = new ProductRule();
			productRuleB2.Set('B', 2, 45);

			var productRuleC1 = new ProductRule();
			productRuleC1.Set('C', 1, 20);

			var productRuleD1 = new ProductRule();
			productRuleD1.Set('D', 1, 15);

			_productRules = new List<IProductRule>();
			_productRules.Add(productRuleA1);
			_productRules.Add(productRuleA3);
			_productRules.Add(productRuleB1);
			_productRules.Add(productRuleB2);
			_productRules.Add(productRuleC1);
			_productRules.Add(productRuleD1);
		}


		[Test]
		public void Checkout_ProductA_Returns_50()
		{
			//var productABasicRule = new Mock<IProductRule>();
			//productABasicRule.Setup(r => r.Set('A', 1, 50));

			var productABasicRule = new ProductRule();
			productABasicRule.Set('A', 1, 50);
			

			var checkout = new Checkout();
			checkout.AddProductRule(productABasicRule);

			var price = checkout.GetPrice("A");
			const double expectedPrice = 50;
		
			Assert.AreEqual(expectedPrice, price);
		}

		[TestCase("", 0)]
		[TestCase("A", 50)]
		[TestCase("AB", 80)]
		[TestCase("CDBA", 115)]
		
		[TestCase("AA", 100)]
		[TestCase("AAA", 130)]
		[TestCase("AAAA", 180)]
		[TestCase("AAAAA", 230)]
		[TestCase("AAAAAA", 260)]

		[TestCase("AAAB", 160)]
		[TestCase("AAABB", 175)]
		[TestCase("AAABBD", 190)]
		[TestCase("DABABA", 190)]
		public void Checkout_Products_Price(string productist, int finalPrice)
		{
			var checkout = new Checkout();
			checkout.AddProductRuleRange(_productRules);

			var price = checkout.GetPrice(productist);

			Assert.AreEqual(finalPrice, price);
		}
    }
}
