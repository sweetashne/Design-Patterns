using System;

namespace AbstractDesignPatter
{
	class Program
	{
		static void Main(string[] args)
		{
			IBook book = null;
			TypeFactory typeFactory = null;
			string getName = null;

			typeFactory = TypeFactory.CreateTypeFactory("Horror");
			Console.WriteLine("Book Type: " + typeFactory.GetType().Name);
			Console.WriteLine();

			book = typeFactory.GetBook("Later");
			getName = book.getName();
			Console.WriteLine("Book Name: " + getName);
			Console.WriteLine();

			typeFactory = TypeFactory.CreateTypeFactory("Comedy");
			Console.WriteLine("Book Type: " + typeFactory.GetType().Name);
			Console.WriteLine();

			book = typeFactory.GetBook("American Cheese");
			getName = book.getName();
			Console.WriteLine("Book Name: " + getName);
		}
	}
}
