namespace Models.Clothes
{
	public class RedTShirt : ClothePiece
	{
		public override string ImagePath => "red_tshirt";

		protected override LaundryProgram Program => new()
		{
			Color = ColorType.Colored
		};
	}
}