#region Usings
using NUnit.Framework;


#endregion


namespace KataGreatestCommonDivisor.Tests
{
	public class GreatestCommonDivisorTests
	{
		/// <summary>
		/// TestFixture defines a class of tests
		/// </summary>
		[TestFixture(), Category("Unit"), Description("GreatestCommonDivisor Tests!")]
		public class Test
		{
			#region Setup and Tear Down
			/// <summary>
			/// TestFixtureSetUp called once before any tests have been run in the same TestFixture
			/// </summary>
			[SetUp]
			public void FixtureSetUp()
			{
				// Set up code here.
			}

			/// <summary>
			/// TestFixtureTearDown called once after all tests have been run in the same TestFixture
			/// </summary>
			[TearDown]
			public void FixtureTearDown()
			{
				// Clear up code here.
			}

			/// <summary>
			/// SetsUp is called once before each Test within the same TestFxiture
			/// </summary>
			[SetUp]
			public void SetUp()
			{
				// Set up code here.
				// If this throws an exception no Test in the TestFixture are run.
			}

			/// <summary>
			/// TearsDown is called once after each Test within the same TestFixture.
			/// </summary>
			[TearDown]
			public void TearDown()
			{
				// Clear up code here.
				// Will not run if no tess are run due to [SetUp] throwing an exception
			}
			#endregion

			/// <summary>
			/// Explicit defines tests which are only run manualy.
			/// </summary>
			[Test]
			public void GreatestCommonDivisor_For_21_And_15_Is_3()
			{
				var greatestCommonDivisor = new GreatestCommonDivisor();
				var result = greatestCommonDivisor.Calculate(21, 15);

				Assert.AreEqual(3, result);
			}
		}
	}
}
