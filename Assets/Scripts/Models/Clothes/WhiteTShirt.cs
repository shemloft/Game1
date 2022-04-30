namespace Models.Clothes
{
	public class WhiteTShirt : ClothePiece
	{
		public override string ImagePath => "white_tshirt.png";

		protected override LaundryProgram Program => new()
		{
			Color = ColorType.White
		};
	}
}