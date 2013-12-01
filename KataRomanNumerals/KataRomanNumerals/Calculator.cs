#region Usings
using System;
using System.Collections.Generic;


#endregion


namespace KataRomanNumerals
{
	public class Calculator
	{
		public string GetRoman(int number)
		{
			if (number == 0)
			{
				return "0";
			}

			var result = string.Empty;
			if (number > 4)
			{
				result = "V";
			}
			else if (number > 3)
			{
				result = "IV";
			}
			else
			{
				result += GetRomanFrom1to3(number);
			}

			return result;
		}


		#region Private Methods
		private string GetRomanFrom1to3(int number)
		{
			if (number > 3)
			{
				throw new ArgumentOutOfRangeException("number", "Number have to be 1 < 3");
			}
			string result = string.Empty;
			for (int i = 0; i < number; i++)
			{
				result += "I";
			}
			return result;
		}
		#endregion
	}
}