namespace AbstractDesignPatter
{
	public class HorrorBookFactory : TypeFactory
	{
		public override IBook GetBook(string BookType)
		{
			if (BookType.Equals("Later"))
			{
				return new Later();
			}
			else if (BookType.Equals("Bridge of Souls"))
			{
				return new BridgeOfSouls();
			}
			else if (BookType.Equals("Down Comes The Night"))
			{
				return new DownComesTheNight();
			}
			else return null;
		}
	}
}
