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
		public string Calculator_GetRoman(int number)
		{
			var calculator = new Calculator();
			return calculator.GetRoman(number);
		}
	}
}
