using System;


namespace KataFizzBuzz
{
	public class MultipleOf3Rule : IRule
	{
		#region Costants
		private const string Word = "Fizz";
		#endregion


		public int Divisor { get; private set; }


		#region Constructors
		public MultipleOf3Rule()
		{
			Divisor = 3;
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