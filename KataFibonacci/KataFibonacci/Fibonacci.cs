using System;
using System.Collections.Generic;
using System.Linq;


namespace KataFibonacci
{
	public class Fibonacci : IFibonacci
	{
		public string GetSequence(int numberOfElements)
		{
			if (numberOfElements == 1)
			{
				return "1";	
			}
			if (numberOfElements == 2)
			{
				return "1,1";
			}

			var elements = new List<int> {1, 1};
			for (int i = 2; i < numberOfElements; i++)
			{
				elements.Add(elements[i - 1] + elements[i - 2]);
			}
			return string.Join(",", elements.Select(s => s.ToString()));
		}
	}
}