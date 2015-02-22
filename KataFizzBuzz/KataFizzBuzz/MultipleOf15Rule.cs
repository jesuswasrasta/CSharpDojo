using System;


namespace KataFizzBuzz
{
	public class MultipleOf15Rule : IRule
	{
		#region Costants
		private const string Word = "FizzBuzz";

		public int Divisor { get; private set;  }
		#endregion


		#region Constructors
		public MultipleOf15Rule()
		{
			Divisor = 15;
		}
		#endregion
		
		public bool IsApplicable(int number)
		{
			return number % Divisor == 0;
		}

		public string GetTheWord(int number)
		{
			if (IsApplicable(number))
			{
				return Word;
			}
			return String.Empty;
		}
	}
}