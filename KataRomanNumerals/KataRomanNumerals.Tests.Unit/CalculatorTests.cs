using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;


namespace KataRomanNumerals.Tests.Unit
{
	[TestFixture]
	public class CalculatorTests
    {
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
		[TestCase(500, Result = "D")]
		[TestCase(999, Result = "CMXCIX")]
		[TestCase(1000, Result = "M")]
		[TestCase(1001, Result = "MI")]
		public string Calculator_GetRoman(int number)
		{
			var calculator = new Calculator();
			return calculator.GetRoman(number);
		}
	}
}
