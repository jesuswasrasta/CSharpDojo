using System;


namespace KataSupermarket
{
	public class ProductWithoutPriceException : Exception
	{
		public ProductWithoutPriceException(string message):base(message)
		{
		}
	}
}