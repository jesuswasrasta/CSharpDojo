using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;


namespace KataSorting.Tests
{
    public class InsertionSorterTests
    {
		[TestCase(new []{8,2,5,1,14,12,76,23,45})]
	    public void InsertionSorter_Sort(int[] elements)
		{
			var insertionSorter = new InsertionSorter();
			var sortedElements = insertionSorter.Sort(elements);

			for (int i = 1; i < sortedElements.Length-1; i++)
			{
				Assert.IsTrue(sortedElements[i] > sortedElements[i-1]);
			}
		}
    }
}
