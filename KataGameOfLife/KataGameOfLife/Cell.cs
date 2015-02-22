namespace KataGameOfLife
{
	public class Cell
	{
		#region Properties
		public bool IsAlive { get; private set; }
		#endregion


		#region Constructors
		public Cell()
		{
		}
		#endregion


		#region Factory Methods
		public static Cell NewDeadCell()
		{
			return new Cell {IsAlive = false};
		}

		public static Cell NewLivingCell()
		{
			return new Cell {IsAlive = true};
		}

		public static Cell FromChar(char aChar)
		{
			switch (aChar)
			{
				case 'O':
					return NewLivingCell();
				case '.':
					return NewDeadCell();
				default:
					return null;
			}
		}
		#endregion


		#region Public Methods
		public void LivingNeighbors(int neighBors)
		{
			IsAlive = neighBors >= 2 & neighBors < 4;
		}
		#endregion


		#region Overridden Methods
		public override string ToString()
		{
			return IsAlive ? "0" : ".";
		}
		#endregion
	}
}