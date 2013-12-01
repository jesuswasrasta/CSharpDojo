#region Usings

using System.Collections.Generic;

#endregion

namespace KataCombinatorics
{
	public interface ICombinatorics
	{
		IEnumerable<string> GetPermutation(string word);
	}
}