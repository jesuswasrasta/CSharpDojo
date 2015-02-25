namespace KataSupermarket
{
	public interface IProductRule
	{
		char Product { get; }

		uint BundleQuantity { get; }

		double FinalPrice { get; }

		void Set(char product, uint bundleQuantity, double finalPrice);
	}
}