#region Usings

using System.Collections.Generic;
using System.Linq;

#endregion

namespace KataCombinatorics
{
	public class Combinatorics : ICombinatorics
	{
		#region Implementation of ICombinatorics

		public IEnumerable<string> GetPermutation(string word)
		{
			if (string.IsNullOrEmpty(word))
			{
				return new string[0];
			}

			if (word.Length == 1)
			{
				return new[] {word};
			}

			return from character in word
			       from permutation in GetPermutation(word.Remove(word.IndexOf(character), 1))
			       select character + permutation;
		}

		#endregion
	}
}