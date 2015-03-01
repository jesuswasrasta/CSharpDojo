#region Usings
using System;
using System.Collections.Generic;
using System.Linq;


#endregion


namespace KataSupermarket
{
	public class Checkout : ICheckout
	{
		#region Fields
		private readonly List<IProductRule> _productRules;
		#endregion


		#region Constructors
		public Checkout()
		{
			_productRules = new List<IProductRule>();
		}
		#endregion


		#region Public Methods
		public void AddProductRule(IProductRule productRule)
		{
			if (productRule == null)
			{
				throw new ArgumentNullException("productRule");
			}
			_productRules.Add(productRule);
		}

		public void AddProductRuleRange(IEnumerable<IProductRule> productRules)
		{
			if (productRules == null)
			{
				throw new ArgumentNullException("productRules");
			}
			_productRules.AddRange(productRules);
		}

		public double GetPrice(string productList)
		{
			if (productList == null)
			{
				throw new ArgumentNullException("productList");
			}

			double price = 0;
			var products = productList.Distinct();
			foreach (var product in products)
			{
				int quantity = productList.Count(p => p.Equals(product));

				var bundleFactory = new BundleFactory();
				var bundles = bundleFactory.MakeBundles(product, (uint)quantity, _productRules);

				price += bundles.Sum(b => b.FinalPrice);
			}

			return price;
		}

		#endregion
	}
}