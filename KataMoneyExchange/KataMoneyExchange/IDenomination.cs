namespace KataMoneyExchange
{
	public interface IDenomination
	{
		Currency Currency { get; }
		int Value { get; }
	}
}