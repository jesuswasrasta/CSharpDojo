#region Usings
using System;
using System.Collections.Generic;
using System.ComponentModel;


#endregion


namespace KataGameOfLife
{
	public class Universe
	{
		public IList<Cell> Cells { get; private set; }


		#region Constructors
		public Universe()
		{
			Cells = new List<Cell>();
		}
		#endregion

		public void SetInitialState(string initialState)
		{
			if (string.IsNullOrEmpty(initialState))
			{
				return;
			}

			var lines = initialState.Split(new[] {'\n', '\r'});
			foreach (var line in lines)
			{
				foreach (var aChar in line.ToCharArray())
				{
					var cell = Cell.FromChar(aChar);
					if (cell == null)
					{
						Cells.Clear();
						return;
					}
					Cells.Add(cell);		
				}
			}
		}
	}
}