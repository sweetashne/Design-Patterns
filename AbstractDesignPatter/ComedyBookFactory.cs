namespace AbstractDesignPatter
{
	public class ComedyBookFactory : TypeFactory
	{
		public override IBook GetBook(string BookType)
		{
			if (BookType.Equals("Alright, Alright, Alright"))
			{
				return new AlrightAlrightAlright();
			}
			else if (BookType.Equals("American Cheese"))
			{
				return new AmericanCheese();
			}
			else return null;
		}
	}
}
