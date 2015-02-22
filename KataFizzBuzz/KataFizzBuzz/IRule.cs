namespace KataFizzBuzz
{
	public interface IRule
	{
		int Divisor { get; }

		bool IsApplicable(int number);

		string GetTheWord(int number);
		
	}
}