namespace Models
{
	public class LaundryProgram
	{
		public ColorType Color { get; set; }
		
	}

	public enum ColorType
	{
		White, Colored, Dark
	}
}