namespace Models.Clothes
{
	public class DarkTShirt : ClothePiece
	{
		public override string ImagePath => "dark_tshirt.png";

		protected override LaundryProgram Program => new()
		{
			Color = ColorType.Dark
		};
	}
}