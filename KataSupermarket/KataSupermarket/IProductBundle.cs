namespace KataSupermarket
{
	public interface IProductBundle
	{
		char Product { get; }

		int Quantity { get; }

		void AddProductRule(IProductRule productRule);

		double GetFinalPrice();
	}
}