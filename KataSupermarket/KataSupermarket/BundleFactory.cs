#region Usings
using System.Collections.Generic;
using System.Linq;


#endregion


namespace KataSupermarket
{
	/// <summary>
	/// Builds bundles of products
	/// </summary>
	public class BundleFactory : IBundleFactory
	{
		public ProductBundle[] MakeBundles(char product, uint totalQuantity, List<IProductRule> productRules)
		{
			var bundles = new List<ProductBundle>();
			while (totalQuantity > 0)
			{
				var actualQuantity = totalQuantity;
				var rulesToApply = productRules.Where(r => r.Product == product && r.BundleQuantity <= actualQuantity).OrderByDescending(p => p.BundleQuantity);
				if (rulesToApply.Any())
				{
					var ruleToApply = rulesToApply.First();
					bundles.Add(new ProductBundle(product, ruleToApply.BundleQuantity, ruleToApply.FinalPrice));

					totalQuantity -= ruleToApply.BundleQuantity;
				}
			}
			return bundles.ToArray();
		}
	}
}