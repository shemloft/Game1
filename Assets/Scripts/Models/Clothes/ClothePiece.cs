namespace Models.Clothes
{
	public abstract class ClothePiece
	{
		public abstract string ImagePath { get; }

		protected abstract LaundryProgram Program { get; }

		public bool ProgramIsCorrect(LaundryProgram laundryProgram)
		{
			return laundryProgram.Color == Program.Color;
		}
	}
}