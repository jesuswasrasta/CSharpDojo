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

		[Test]
		public void MoneyExchanger_GetDenominations_Amount1Euro_1EuroDenomination()
		{
			var moneyExchanger = new MoneyExchanger();
			var denominations = moneyExchanger.GetDenominations(1);

			var denomination = new Denomination(Currency.Euro, 1000);
			Assert.IsTrue(denominations.Count == 1 && denominations.ContainsKey(denomination) && denominations[denomination] == 1);
		}
	}
}