namespace KataSupermarket
{
	public interface ICheckout
	{
		void AddProductRule(IProductRule productRule);

		double GetPrice(string productList);
	}
}