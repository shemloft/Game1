namespace Models.Clothes
{
	public class DarkTShirt : ClothePiece
	{
		public override string ImagePath => "Dark_tshirt";

		protected override LaundryProgram Program => new()
		{
			Color = ColorType.Dark
		};
	}
}