#region Usings

using System.Linq;
using NUnit.Framework;

#endregion

namespace KataCombinatorics.Tests
{
	[TestFixture]
	public class CombinatoricsTests
	{
		#region Setup/Teardown

		[SetUp]
		public void SetupTest()
		{
		}

		[TearDown]
		public void TearDownTest()
		{
		}

		#endregion

		[SetUp]
		public void SetupMethods()
		{
		}

		[TearDown]
		public void TearDownMethods()
		{
		}


		[Test]
		public void Combinatorics_GetPermutations_EmptyString_ShouldReturn_EmptyStringList()
		{
			ICombinatorics combinator = new Combinatorics();
			var combinations = combinator.GetPermutation(string.Empty);
			Assert.IsTrue(!combinations.Any());
		}

		[Test]
		public void Combinatorics_GetPermutations_Null_ShouldReturn_EmptyStringList()
		{
			ICombinatorics combinator = new Combinatorics();
			var combinations = combinator.GetPermutation(null);
			Assert.IsTrue(!combinations.Any());
		}

		[Test]
		public void Combinatorics_GetPermutations_OneCharString_ShouldReturn_SameString()
		{
			ICombinatorics combinator = new Combinatorics();
			var combinations = combinator.GetPermutation("a");
			Assert.IsTrue(combinations.FirstOrDefault() == "a");
		}

		[Test]
		public void Combinatorics_GetPermutations_OneString_ShouldNotContainsDuplicates()
		{
			ICombinatorics combinator = new Combinatorics();
			var combinations = combinator.GetPermutation("albero");
			var duplicateItems = combinations.GroupBy(x => x).Where(grouped => grouped.Count() > 1).Select(grouped => grouped.Key);
			Assert.IsTrue(!duplicateItems.Any());
		}

		[Test]
		public void Combinatorics_GetPermutations_OneString_ShouldReturn_Combinatorics()
		{
			ICombinatorics combinator = new Combinatorics();
			var combinations = combinator.GetPermutation("pippo");
			Assert.IsTrue(combinations.Any());
		}
	}
}