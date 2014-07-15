using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;


namespace KataGameOfLife.Tests
{
	[TestFixture]
	public class UniverseTests
	{
		[Test]
		public void Universe_SetInitialState_NullString_CellsCountIs0()
		{
			var universe = new Universe();
			universe.SetInitialState(null);

			Assert.IsTrue(universe.Cells.Count == 0);
		}

		[Test]
		public void Universe_SetInitialState_EmptyString_CellsCountIs0()
		{
			var universe = new Universe();
			universe.SetInitialState(string.Empty);

			Assert.IsTrue(universe.Cells.Count == 0);
		}

		[Test]
		public void Universe_SetInitialState_OneDeadCell_CellCountIs1()
		{
			var universe = new Universe();
			universe.SetInitialState(".");

			Assert.IsTrue(universe.Cells.Count == 1);
		}

		[Test]
		public void Universe_SetInitialState_StringContainsInvalidChars_CellCountIs0()
		{
			var universe = new Universe();
			universe.SetInitialState(".x.");

			Assert.IsTrue(universe.Cells.Count == 0);
		}


		[Test]
		public void Universe_SetInitialState_ValidStringWith4Cells_CellCountIs4()
		{
			var universe = new Universe();
			universe.SetInitialState(".OOO");

			Assert.IsTrue(universe.Cells.Count == 4);
		}
	}
}
