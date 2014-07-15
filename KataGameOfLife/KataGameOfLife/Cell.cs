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
			return new Cell { IsAlive = true };
		}
		#endregion


		public void Neighbors(int neighBors)
		{
			if (neighBors == 0)
			{
				IsAlive = false;
			}
		}
	}
}