#region Usings
using System;

using NUnit.Framework;


#endregion


namespace KataRomanNumerals.Tests.Unit
{
	[TestFixture]
	public class CalculatorTests
	{

		#region GetRoman
		[TestCase(0, Result = "0")]
		[TestCase(1, Result = "I")]
		[TestCase(2, Result = "II")]
		[TestCase(3, Result = "III")]
		[TestCase(4, Result = "IV")]
		[TestCase(5, Result = "V")]
		[TestCase(6, Result = "VI")]
		[TestCase(7, Result = "VII")]
		[TestCase(8, Result = "VIII")]
		[TestCase(9, Result = "IX")]
		[TestCase(10, Result = "X")]
		[TestCase(11, Result = "XI")]
		[TestCase(12, Result = "XII")]
		[TestCase(13, Result = "XIII")]
		[TestCase(14, Result = "XIV")]
		[TestCase(15, Result = "XV")]
		[TestCase(16, Result = "XVI")]
		[TestCase(17, Result = "XVII")]
		[TestCase(18, Result = "XVIII")]
		[TestCase(19, Result = "XIX")]
		[TestCase(20, Result = "XX")]
		[TestCase(30, Result = "XXX")]
		[TestCase(47, Result = "XLVII")]
		[TestCase(50, Result = "L")]
		[TestCase(73, Result = "LXXIII")]
		[TestCase(89, Result = "LXXXIX")]
		[TestCase(100, Result = "C")]
		[TestCase(327, Result = "CCCXXVII")]
		[TestCase(423, Result = "CDXXIII")]
		[TestCase(500, Result = "D")]
		[TestCase(999, Result = "CMXCIX")]
		[TestCase(1000, Result = "M")]
		[TestCase(1666, Result = "MDCLXVI")]
		[TestCase(2000, Result = "MM")]
		[TestCase(3000, Result = "MMM")]
		[TestCase(4000, Result = "MMMM")]
		[TestCase(9000, Result = "MMMMMMMMM")]
		public string Calculator_GetRoman(int number)
		{
			var calculator = new Calculator();
			return calculator.GetRoman(number);
		}
		
		[Test]
		public void Calculator_GetRoman_NumberGreaterThan9999_ThrowsException()
		{
			var calculator = new Calculator();
			Assert.Throws<Exception>(() => calculator.GetRoman(10000));
		}
		#endregion


		#region GetRoman2
		[TestCase(0, Result = "0")]
		[TestCase(1, Result = "I")]
		[TestCase(2, Result = "II")]
		[TestCase(3, Result = "III")]
		[TestCase(4, Result = "IV")]
		[TestCase(5, Result = "V")]
		[TestCase(6, Result = "VI")]
		[TestCase(7, Result = "VII")]
		[TestCase(8, Result = "VIII")]
		[TestCase(9, Result = "IX")]
		[TestCase(10, Result = "X")]
		[TestCase(11, Result = "XI")]
		[TestCase(12, Result = "XII")]
		[TestCase(13, Result = "XIII")]
		[TestCase(14, Result = "XIV")]
		[TestCase(15, Result = "XV")]
		[TestCase(16, Result = "XVI")]
		[TestCase(17, Result = "XVII")]
		[TestCase(18, Result = "XVIII")]
		[TestCase(19, Result = "XIX")]
		[TestCase(20, Result = "XX")]
		[TestCase(30, Result = "XXX")]
		[TestCase(47, Result = "XLVII")]
		[TestCase(50, Result = "L")]
		[TestCase(73, Result = "LXXIII")]
		[TestCase(89, Result = "LXXXIX")]
		[TestCase(100, Result = "C")]
		[TestCase(327, Result = "CCCXXVII")]
		[TestCase(423, Result = "CDXXIII")]
		[TestCase(500, Result = "D")]
		[TestCase(999, Result = "CMXCIX")]
		[TestCase(1000, Result = "M")]
		[TestCase(1666, Result = "MDCLXVI")]
		[TestCase(2000, Result = "MM")]
		[TestCase(3000, Result = "MMM")]
		[TestCase(4000, Result = "MMMM")]
		[TestCase(9000, Result = "MMMMMMMMM")]
		public string Calculator_GetRoman2(int number)
		{
			var calculator = new Calculator();
			string roman = string.Empty;
			calculator.GetRoman2(number, ref roman);
			return roman;
		}

		[Test]
		public void Calculator_GetRoman2_NumberGreaterThan9999_ThrowsException()
		{
			var calculator = new Calculator();
			string roman = string.Empty;
			Assert.Throws<Exception>(() => calculator.GetRoman2(10000, ref roman));
		}
		#endregion


		#region GetNumber
		[TestCase("0", Result = 0)]
		[TestCase("I", Result = 1)]
		[TestCase("II", Result = 2)]
		[TestCase("III", Result = 3)]
		[TestCase("IV", Result = 4)]
		[TestCase("V", Result = 5)]
		[TestCase("VI", Result = 6)]
		public int Calculator_GetNumber(string roman)
		{
			var calculator = new Calculator();
			return calculator.GetNumber(roman);
		}
		#endregion
	}
}