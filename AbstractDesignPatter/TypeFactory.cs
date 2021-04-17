namespace AbstractDesignPatter
{
	public abstract class TypeFactory
	{
		public abstract IBook GetBook(string BookType);

		public static TypeFactory CreateTypeFactory(string BookType)
		{
			if (BookType.Equals("Horror"))
				return new HorrorBookFactory();
			else
				return new ComedyBookFactory();
		}
	}
}
