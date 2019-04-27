#region Usings
using System;


#endregion


namespace KataFizzBuzz
{
	public class MultipleRule : IRule
	{
		#region Constructors
		public MultipleRule(int divisor, string wordToSay)
		{
			Divisor = divisor;
			WordToSay = wordToSay;
		}
		#endregion


		#region Properties
		public string WordToSay { get; private set; }

		public int Divisor { get; private set; }
		#endregion


		#region Public Methods
		public bool IsApplicable(int number)
		{
			return number != 0 && Divisor != 0 && number%Divisor == 0;
		}

		public string GetTheWord(int number)
		{
			return IsApplicable(number) ? WordToSay : string.Empty;
		}
		#endregion
	}
}