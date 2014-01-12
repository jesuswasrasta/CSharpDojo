#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


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

			var result = new StringBuilder();
			while (number >= 1000)
			{
				result.Append("M");
				number = number - 1000;
			}
			if (number >= 900)
			{
				result.Append("CM");
				number = number - 900;
			}
			if (number >= 500)
			{
				result.Append("D");
				number = number - 500;
			}
			if (number >= 400)
			{
				result.Append("CD");
				number = number - 400;
			}
			while (number >= 100)
			{
				result.Append("C");
				number = number - 100;
			}
			if (number >= 90)
			{
				result.Append("XC");
				number = number - 90;
			}
			if (number >= 50)
			{
				result.Append("L");
				number = number - 50;
			}
			if (number >= 40)
			{
				result.Append("XL");
				number = number - 40;
			}
			while (number >= 10)
			{
				result.Append("X");
				number = number - 10;
			}
			if (number >= 9)
			{
				result.Append("IX");
				number = number - 9;
			}
			if (number >= 5)
			{
				result.Append("V");
				number = number - 5;
			}
			if (number >= 4)
			{
				result.Append("IV");
				number = number - 4;
			}
			while (number >= 1)
			{
				result.Append("I");
				number = number - 1;
			}

			return result.ToString();
		}
	}
}
