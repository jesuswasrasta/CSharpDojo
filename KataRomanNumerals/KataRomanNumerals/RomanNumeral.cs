namespace KataRomanNumerals
{
	public struct RomanNumeral
	{
		#region Properties
		public int Value { get; private set; }

		public string Representation { get; private set; }
		#endregion


		#region Constructors
		public RomanNumeral(int value = 0, string representation = "0") : this()
		{
			Value = value;
			Representation = representation;
		}
		#endregion
	}
}