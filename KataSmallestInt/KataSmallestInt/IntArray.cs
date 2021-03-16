using System.Collections.Generic;
using System.Linq;

namespace KataSmallestInt
{
	public class IntArray
	{
		public int FindSmallestInt(int[] args)
		{
			var ints = new List<int>(args);
            ints.Sort();
            return ints.First();
        }
	}
}