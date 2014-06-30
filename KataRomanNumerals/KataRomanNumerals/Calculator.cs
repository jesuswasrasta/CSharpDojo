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
		#region Fields
		private readonly List<RomanNumeral> _romanSystem;
		#endregion


		#region Constructors
		public Calculator()
		{
			_romanSystem = new List<RomanNumeral>
			{
				new RomanNumeral(0, "0"),
				new RomanNumeral(1, "I"),
				new RomanNumeral(4, "IV"),
				new RomanNumeral(5, "V"),
				new RomanNumeral(9, "IX"),
				new RomanNumeral(10, "X"),
				new RomanNumeral(40, "XL"),
				new RomanNumeral(50, "L"),
				new RomanNumeral(90, "XC"),
				new RomanNumeral(100, "C"),
				new RomanNumeral(400, "CD"),
				new RomanNumeral(500, "D"),
				new RomanNumeral(900, "CM"),
				new RomanNumeral(1000, "M"),
				new RomanNumeral(10000, "-"),
			};
		}
		#endregion


		#region Public Methods
		public string GetRoman(int number)
		{
			if (number == 0)
			{
				return "0";
			}

			if (number > 9999)
			{
				throw new Exception("I will not translate numbers greater than 9999!");
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

		public void GetRoman2(int number, ref string roman)
		{
			if (number == 0)
			{
				if (string.IsNullOrEmpty(roman))
				{
					roman = "0";
				}
				return;
			}

			foreach (var romanNumeral in _romanSystem.OrderByDescending(r => r.Value))
			{
				if (number >= romanNumeral.Value)
				{
					roman += romanNumeral.Representation;
					GetRoman2(number - romanNumeral.Value, ref roman);
					break;
				}
			}
		}

		public void GetNumber(string roman, ref int number)
		{
			if (string.IsNullOrEmpty(roman) || roman.Equals("0"))
			{
				return;
			}

			foreach (var romanNumeral in _romanSystem.OrderBy(r => r.Value))
			{
				if (romanNumeral.Representation.Length > roman.Length)
				{
					continue;
				}
				
				var text = roman.Substring(roman.Length - romanNumeral.Representation.Length, romanNumeral.Representation.Length);
				if (text.Equals(romanNumeral.Representation))
				{
					number += romanNumeral.Value;

					if (roman.Length >= 2)
					{
						GetNumber(roman.Substring(0, roman.Length - romanNumeral.Representation.Length), ref number);
					}
					break;
				}
			}
		}
		#endregion
	}
}