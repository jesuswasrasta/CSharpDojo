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
			var number1 = 0;
			var number2 = 0;
			var numbers = inputString.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);
			if (numbers.Length >= 1)
			{
				int.TryParse(numbers[0], out number1);	
			}
			if (numbers.Length >= 2)
			{
				int.TryParse(numbers[1], out number2);
			}
			result = number1 + number2;
			
			return result;
		}
	}
}