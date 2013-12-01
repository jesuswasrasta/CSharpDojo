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
		[Test]
		public void Calculator_GetRoman_0_Returns_0()
		{
			var calculator = new Calculator();
			Assert.IsTrue(calculator.GetRoman(0) == "0");
		}

		[Test]
		public void Calculator_GetRoman_1_Returns_I()
		{
			var calculator = new Calculator();
			Assert.IsTrue(calculator.GetRoman(1) == "I");
		}

		[Test]
		public void Calculator_GetRoman_2_Returns_II()
		{
			var calculator = new Calculator();
			Assert.IsTrue(calculator.GetRoman(2) == "II");
		}

		[Test]
		public void Calculator_GetRoman_3_Returns_III()
		{
			var calculator = new Calculator();
			Assert.IsTrue(calculator.GetRoman(3) == "III");
		}

		[Test]
		public void Calculator_GetRoman_4_Returns_IV()
		{
			var calculator = new Calculator();
			Assert.IsTrue(calculator.GetRoman(4) == "IV");
		}

		[Test]
		public void Calculator_GetRoman_5_Returns_V()
		{
			var calculator = new Calculator();
			Assert.IsTrue(calculator.GetRoman(5) == "V");
		}

		[Test]
		public void Calculator_GetRoman_6_Returns_VI()
		{
			var calculator = new Calculator();
			Assert.IsTrue(calculator.GetRoman(6) == "VI");
		}
	}
}
