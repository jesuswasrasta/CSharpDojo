#region Usings
using System;
using System.Collections.Generic;
using System.ComponentModel;


#endregion


namespace KataGameOfLife
{
	public class Universe
	{
		#region Properties
		public IList<Cell> Cells { get; private set; }
		#endregion


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

			var lines = initialState.Split('\n', '\r');
			foreach (var line in lines)
			{
				foreach (var character in line.ToCharArray())
				{
					var cell = Cell.FromChar(character);
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