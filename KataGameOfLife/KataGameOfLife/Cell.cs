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


		#region Factroy Methods
		public static Cell NewDeadCell()
		{
			return new Cell {IsAlive = false};
		}

		public static Cell NewLivingCell()
		{
			return new Cell {IsAlive = true};
		}
		#endregion


		#region Public Methods
		public void LivingNeighbors(int neighBors)
		{
			IsAlive = neighBors >= 2 & neighBors < 4;
		}
		#endregion
	}
}