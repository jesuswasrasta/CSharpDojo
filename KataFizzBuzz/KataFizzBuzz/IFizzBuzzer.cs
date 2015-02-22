namespace KataFizzBuzz
{
	public interface IFizzBuzzer
	{
		string Say(int number);

		void AddRule(IRule rule);
	}
}