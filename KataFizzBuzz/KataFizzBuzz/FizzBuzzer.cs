#region Usings
using System.Collections.Generic;
using System.Linq;


#endregion


namespace KataFizzBuzz
{
	public class FizzBuzzer : IFizzBuzzer
	{
		#region Fields
		private readonly IList<IRule> _rules;
		#endregion


		#region Constructors
		public FizzBuzzer()
		{
			_rules = new List<IRule>();
		}
		#endregion


		#region Public Methods
		public void AddRule(IRule rule)
		{
			_rules.Add(rule);
		}

		public string Say(int number)
		{
			var ruleToApply = _rules.OrderByDescending(r => r.Divisor).FirstOrDefault(r => r.IsApplicable(number));
			if (ruleToApply != null)
			{
				return ruleToApply.GetTheWord(number);
			}
			return number.ToString();
		}
		#endregion
	}
}