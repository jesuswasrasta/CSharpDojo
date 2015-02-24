#region Usings
using System.Collections.Generic;


#endregion


namespace KataPrimeFactors
{
	public class PrimeFactors
	{
		public int[] Get(int number)
		{
			var factors = new List<int>();
			if (number < 2)
			{
				factors.Add(number);
				return factors.ToArray();
			}

			if (IsAPrimeNumber(number))
			{
				factors.Add(number);
				return factors.ToArray();
			}

			for (int factor = number - 1; factor > 1; factor--)
			{
				if (!IsAPrimeNumber(factor))
				{
					continue;
				}
				if (number%factor == 0)
				{
					factors.Add(factor);
				}
			}
			return factors.ToArray();
		}

		private bool IsAPrimeNumber(int number)
		{
			for (int i = number - 1; i > 1; i--)
			{
				if (number%i == 0)
				{
					return false;
				}
			}
			return true;
		}
	}
}