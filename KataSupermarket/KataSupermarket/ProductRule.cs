namespace KataSupermarket
{
	public class ProductRule : IProductRule
	{
		public char Product { get; private set; }

		public uint BundleQuantity { get; private set; }

		public double FinalPrice { get; private set; }

		public void Set(char product, uint bundleQuantity, double finalPrice)
		{
			Product = product;
			BundleQuantity = bundleQuantity;
			FinalPrice = finalPrice;
		}
	}
}