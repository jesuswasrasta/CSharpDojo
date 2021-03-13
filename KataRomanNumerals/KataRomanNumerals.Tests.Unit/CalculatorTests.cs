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
		[TestCase(0, ExpectedResult = "0")]
		[TestCase(1, ExpectedResult = "I")]
		[TestCase(2, ExpectedResult = "II")]
		[TestCase(3, ExpectedResult = "III")]
		[TestCase(4, ExpectedResult = "IV")]
		[TestCase(5, ExpectedResult = "V")]
		[TestCase(6, ExpectedResult = "VI")]
		[TestCase(7, ExpectedResult = "VII")]
		[TestCase(8, ExpectedResult = "VIII")]
		[TestCase(9, ExpectedResult = "IX")]
		[TestCase(10, ExpectedResult = "X")]
		[TestCase(11, ExpectedResult = "XI")]
		[TestCase(12, ExpectedResult = "XII")]
		[TestCase(13, ExpectedResult = "XIII")]
		[TestCase(14, ExpectedResult = "XIV")]
		[TestCase(15, ExpectedResult = "XV")]
		[TestCase(16, ExpectedResult = "XVI")]
		[TestCase(17, ExpectedResult = "XVII")]
		[TestCase(18, ExpectedResult = "XVIII")]
		[TestCase(19, ExpectedResult = "XIX")]
		[TestCase(20, ExpectedResult = "XX")]
		[TestCase(30, ExpectedResult = "XXX")]
		[TestCase(47, ExpectedResult = "XLVII")]
		[TestCase(50, ExpectedResult = "L")]
		[TestCase(73, ExpectedResult = "LXXIII")]
		[TestCase(89, ExpectedResult = "LXXXIX")]
		[TestCase(100, ExpectedResult = "C")]
		[TestCase(327, ExpectedResult = "CCCXXVII")]
		[TestCase(423, ExpectedResult = "CDXXIII")]
		[TestCase(500, ExpectedResult = "D")]
		[TestCase(999, ExpectedResult = "CMXCIX")]
		[TestCase(1000, ExpectedResult = "M")]
		[TestCase(1666, ExpectedResult = "MDCLXVI")]
		[TestCase(2000, ExpectedResult = "MM")]
		[TestCase(3000, ExpectedResult = "MMM")]
		[TestCase(4000, ExpectedResult = "MMMM")]
		[TestCase(9000, ExpectedResult = "MMMMMMMMM")]
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
		[TestCase(0, ExpectedResult = "0")]
		[TestCase(1, ExpectedResult = "I")]
		[TestCase(2, ExpectedResult = "II")]
		[TestCase(3, ExpectedResult = "III")]
		[TestCase(4, ExpectedResult = "IV")]
		[TestCase(5, ExpectedResult = "V")]
		[TestCase(6, ExpectedResult = "VI")]
		[TestCase(7, ExpectedResult = "VII")]
		[TestCase(8, ExpectedResult = "VIII")]
		[TestCase(9, ExpectedResult = "IX")]
		[TestCase(10, ExpectedResult = "X")]
		[TestCase(11, ExpectedResult = "XI")]
		[TestCase(12, ExpectedResult = "XII")]
		[TestCase(13, ExpectedResult = "XIII")]
		[TestCase(14, ExpectedResult = "XIV")]
		[TestCase(15, ExpectedResult = "XV")]
		[TestCase(16, ExpectedResult = "XVI")]
		[TestCase(17, ExpectedResult = "XVII")]
		[TestCase(18, ExpectedResult = "XVIII")]
		[TestCase(19, ExpectedResult = "XIX")]
		[TestCase(20, ExpectedResult = "XX")]
		[TestCase(30, ExpectedResult = "XXX")]
		[TestCase(47, ExpectedResult = "XLVII")]
		[TestCase(50, ExpectedResult = "L")]
		[TestCase(73, ExpectedResult = "LXXIII")]
		[TestCase(89, ExpectedResult = "LXXXIX")]
		[TestCase(100, ExpectedResult = "C")]
		[TestCase(327, ExpectedResult = "CCCXXVII")]
		[TestCase(423, ExpectedResult = "CDXXIII")]
		[TestCase(500, ExpectedResult = "D")]
		[TestCase(999, ExpectedResult = "CMXCIX")]
		[TestCase(1000, ExpectedResult = "M")]
		[TestCase(1666, ExpectedResult = "MDCLXVI")]
		[TestCase(2000, ExpectedResult = "MM")]
		[TestCase(3000, ExpectedResult = "MMM")]
		[TestCase(4000, ExpectedResult = "MMMM")]
		[TestCase(9000, ExpectedResult = "MMMMMMMMM")]
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
		[TestCase("0", ExpectedResult = 0)]
		[TestCase("I", ExpectedResult = 1)]
		[TestCase("II", ExpectedResult = 2)]
		[TestCase("III", ExpectedResult = 3)]
		[TestCase("IV", ExpectedResult = 4)]
		[TestCase("V", ExpectedResult = 5)]
		[TestCase("VI", ExpectedResult = 6)]
		[TestCase("VII", ExpectedResult = 7)]
		[TestCase("VIII", ExpectedResult = 8)]
		[TestCase("IX", ExpectedResult = 9)]
		[TestCase("X", ExpectedResult = 10)]
		[TestCase("XI", ExpectedResult = 11)]
		[TestCase("XII", ExpectedResult = 12)]
		[TestCase("XIII", ExpectedResult = 13)]
		[TestCase("XIV", ExpectedResult = 14)]
		[TestCase("XV", ExpectedResult = 15)]
		[TestCase("XVI", ExpectedResult = 16)]
		[TestCase("XVII", ExpectedResult = 17)]
		[TestCase("XVIII", ExpectedResult = 18)]
		[TestCase("XIX", ExpectedResult = 19)]
		[TestCase("XX", ExpectedResult = 20)]
		[TestCase("XXX", ExpectedResult = 30)]
		[TestCase("XLVII", ExpectedResult = 47)]
		[TestCase("L", ExpectedResult = 50)]
		[TestCase("LXXIII", ExpectedResult = 73)]
		[TestCase("LXXXIX", ExpectedResult = 89)]
		[TestCase("C", ExpectedResult = 100)]
		[TestCase("CCCXXVII", ExpectedResult = 327)]
		[TestCase("CDXXIII", ExpectedResult = 423)]
		[TestCase("D", ExpectedResult = 500)]
		[TestCase("CMXCIX", ExpectedResult = 999)]
		[TestCase("M", ExpectedResult = 1000)]
		[TestCase("MDCLXVI", ExpectedResult = 1666)]
		[TestCase("MM", ExpectedResult = 2000)]
		[TestCase("MMM", ExpectedResult = 3000)]
		[TestCase("MMMM", ExpectedResult = 4000)]
		[TestCase("MMMMMMMMM", ExpectedResult = 9000)]
		public int Calculator_GetNumber(string roman)
		{
			int number = 0;
			var calculator = new Calculator();
			calculator.GetNumber(roman, ref number);
			return number;
		}
		#endregion
	}
}