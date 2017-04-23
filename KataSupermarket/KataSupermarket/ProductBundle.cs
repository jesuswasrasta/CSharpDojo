#region Usings

#endregion


namespace KataSupermarket
{
	/// <summary>
	///     Product bundle value object
	/// </summary>
	public class ProductBundle
	{
		#region Constructors		
		public ProductBundle(char product, uint quantity, double finalPrice)
		{
			Product = product;
			Quantity = quantity;
			FinalPrice = finalPrice;
		}
		#endregion


		#region Properties
		public char Product { get; }

		public uint Quantity { get; }

		public double FinalPrice { get; set; }
		#endregion
	}
}