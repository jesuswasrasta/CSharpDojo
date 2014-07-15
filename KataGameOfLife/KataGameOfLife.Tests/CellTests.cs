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
		//http://en.wikipedia.org/wiki/Conway's_Game_of_Life#Rules

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

		[TestCase(0, Result = false)]
		[TestCase(1, Result = false)]
		[TestCase(4, Result = false)]
		[TestCase(5, Result = false)]
		[TestCase(2, Result = true)]
		[TestCase(3, Result = true)]
		public bool LivingCell_LivingNeighborsTest(int livingNeighBors)
		{
			var cell = Cell.NewLivingCell();
			cell.LivingNeighbors(livingNeighBors);
			return cell.IsAlive;
		}
	}
}
