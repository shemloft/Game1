namespace Models.Clothes
{
	public class ClothesFactory
	{
		public static ClothePiece[] GetClothes()
		{
			return new ClothePiece[] {new DarkTShirt(), new RedTShirt(), new WhiteTShirt()};
		}
	}
}