using NUnit.Framework;


namespace KataMoneyExchange.Tests.Unit
{
	[TestFixture]
	public class MoneyExchangerTests
	{
		[SetUp]
		public void Init()
		{
		}

		[TearDown]
		public void TearDown()
		{
		}

		[Test]
		public void MoneyExchanger_GetDenominations_AmountZero_ReturnsNoDenominations()
		{
			var moneyExchanger = new MoneyExchanger();
			var denominations = moneyExchanger.GetDenominations(0);

			Assert.IsTrue(denominations.Count == 0);
		}
	}
}