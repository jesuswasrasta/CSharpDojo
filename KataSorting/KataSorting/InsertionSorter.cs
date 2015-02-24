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
						//nando20150224: swapping with a 3rd var? Loooooser :P
						//var temp = elements[i];
						//elements[i] = elements[i - 1];
						//elements[i - 1] = temp;

						//nando20150224: cool swapping, bro! 8)
						elements[i] =elements[i] + elements[i - 1];
						elements[i - 1] = elements[i] - elements[i - 1];
						elements[i] = elements[i] - elements[i - 1];
						unsorted = true;
					}
				}				
			}
			return elements;
		}
	}
}