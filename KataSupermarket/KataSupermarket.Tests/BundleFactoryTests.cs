#region Usings
using System;
using System.Collections.Generic;
using System.Linq;

using NUnit.Framework;


#endregion


namespace KataSupermarket.Tests
{
	[TestFixture]
    public class BundleFactoryTests
    {
		[SetUp]
		public void Setup()
		{
		}


		[Test]
		public void BundleFactory_ProductA_1_50_GetFinalPrice_Returns_50()
		{
			var productARules = new List<IProductRule>();
			var productABasicRule = new ProductRule();
			productABasicRule.Set('A', 1, 50);
			productARules.Add(productABasicRule);

			var bundleFactory = new BundleFactory();
			var bundles = bundleFactory.MakeBundles('A', 1, productARules);
	
			Assert.IsNotNull(bundles);
			Assert.AreEqual(1, bundles.Length);
			Assert.AreEqual(50, bundles.FirstOrDefault()?.FinalPrice);
		}


		[TestCase('A', (uint)1, 50)]
		public void BundleFactory_Tests(char product, uint quantity, double finalPrice)
		{
			var productARules = new List<IProductRule>();
			var productABasicRule = new ProductRule();
			productABasicRule.Set(product, quantity, finalPrice);
			productARules.Add(productABasicRule);

			var bundleFactory = new BundleFactory();
			var bundles = bundleFactory.MakeBundles(product, quantity, productARules);

			Assert.IsNotNull(bundles);
			Assert.AreEqual(1, bundles.Length);
			Assert.AreEqual(50, bundles.FirstOrDefault()?.FinalPrice);
		}


		[TestCase('A', "1,50", (uint)1, 50)]
		[TestCase('A', "1,50;3,130", (uint)5, 230)]
		public void BundleFactory_Tests(char product, string productRulesCsv, uint quantity, double finalPrice)
		{
			var productRules = new List<IProductRule>();
			var stringRules = productRulesCsv.Split(new []{';'}, StringSplitOptions.RemoveEmptyEntries);
			foreach (var stringRule in stringRules)
			{
				var stringRuleElemnts = stringRule.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);

				uint bundleQuantity = 0;
				double bundleFinalPrice = 0;
				uint.TryParse(stringRuleElemnts[0], out bundleQuantity);
				double.TryParse(stringRuleElemnts[1], out bundleFinalPrice);

				var rule = new ProductRule();
				rule.Set(product, bundleQuantity, bundleFinalPrice);

				productRules.Add(rule);
			}
			
			var bundleFactory = new BundleFactory();
			var bundles = bundleFactory.MakeBundles(product, quantity, productRules);

			Assert.AreEqual(finalPrice, bundles.Sum(b => b.FinalPrice));
		}
    }
}
