namespace KataStringCalculator
{
	public class StringCalculator
	{
		public int Add(string inputString)
		{
			if (string.IsNullOrEmpty(inputString))
			{
				return 0;
			}

			//nando20150227: work incrementally... This code works only for single numer strings, I know.
			var result = 0;
			int.TryParse(inputString, out result);
			return result;
		}
	}
}