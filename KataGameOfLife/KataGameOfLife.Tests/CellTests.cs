using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;


namespace KataGameOfLife.Tests
{
	[TestFixture]
    public class CellTests
    {
		[Test]
		public void Cell_NewDeadCell_ReturnsDeadCell()
		{
			var cell = Cell.NewDeadCell();
			Assert.IsFalse(cell.IsAlive);
		}

		[Test]
		public void Cell_NewLivingCell_ReturnsDeadCell()
		{
			var cell = Cell.NewLivingCell();
			Assert.IsTrue(cell.IsAlive);
		}

		[Test]
		public void LivingCell_DiesByLoneliness()
		{
			var cell = Cell.NewLivingCell();
			cell.Neighbors(0);
			Assert.IsFalse(cell.IsAlive);
		}
	}
}
