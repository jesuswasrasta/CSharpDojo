namespace KataSorting
{
	public class InsertionSorter
	{
		public int[] Sort(int[] elements)
		{
			bool unsorted = true;
			while (unsorted)
			{
				unsorted = false;
				for (int i = 1; i < elements.Length - 1; i++)
				{
					if (elements[i] < elements[i - 1])
					{
						var temp = elements[i];
						elements[i] = elements[i - 1];
						elements[i - 1] = temp;
						unsorted = true;
					}
				}				
			}
			return elements;
		}
	}
}