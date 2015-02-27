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

			//nando20150227: sounds weird, but fior now it works; remember: you have to work incrementally!
			if (inputString == "1")
			{
				return 1;
			}
			return 0;
		}
	}
}