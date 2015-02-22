using System;


namespace KataFizzBuzz
{
	public class MultipleOf5Rule : IRule
	{
		#region Costants
		private const string Word = "Buzz";
		#endregion


		public int Divisor { get; private set; }


		#region Constructors
		public MultipleOf5Rule()
		{
			Divisor = 5;
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