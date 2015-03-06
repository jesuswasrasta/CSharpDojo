using System.Collections.Generic;


namespace KataSupermarket
{
	public interface IBundleFactory
	{
		ProductBundle[] MakeBundles(char product, uint totalQuantity, List<IProductRule> productRules);
	}
}