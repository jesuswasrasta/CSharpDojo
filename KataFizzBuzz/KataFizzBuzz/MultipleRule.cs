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
			return number%Divisor == 0;
		}

		public string GetTheWord(int number)
		{
			if (IsApplicable(number))
			{
				return WordToSay;
			}
			return String.Empty;
		}
		#endregion
	}
}