using System;


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

			//nando20150227: work incrementally... This code smells like rotten eggs and works only for 1 or 2 numbers.
			var result = 0;
			var tempNumber = 0;
			var numbers = inputString.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
			foreach (var number in numbers)
			{
				int.TryParse(number, out tempNumber);
				result += tempNumber;
			}

			return result;
		}
	}
}