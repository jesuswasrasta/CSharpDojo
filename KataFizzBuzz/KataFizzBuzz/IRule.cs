namespace KataFizzBuzz
{
	public interface IRule
	{
		int Divisor { get; }

		string WordToSay { get; }

		bool IsApplicable(int number);

		string GetTheWord(int number);
		
	}
}