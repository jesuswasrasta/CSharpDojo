using System;


namespace SmallestInt
{
	public class IntArray
	{
		public int FindSmallestInt(int[] args)
		{
			var finished = false;
			while (!finished)
			{
				finished = true;
				for (var i = 1; i < args.Length; i++)
				{
					if (args[i] < args[i - 1])
					{
						var a = args[i - 1];
						args[i - 1] = args[i];
						args[i] = a;
						finished = false;
					}
				}
			}
			return args[0];
		}
	}
}