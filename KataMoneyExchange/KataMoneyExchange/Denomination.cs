namespace KataMoneyExchange
{
	public class Denomination : IDenomination
	{
		#region Properties
		public Currency Currency { get; private set; }
		public int Value { get; private set; }
		#endregion


		#region Constructors	
		public Denomination(Currency currency, int value)
		{
			Currency = currency;
			Value = value;
		}
		#endregion
	}
}