using System;

namespace BuilderDesignPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			var builder = new PizzaBuilder();
			var director = new PizzaDirector(builder);
			string input;

			Console.WriteLine("Menu:");
			Console.WriteLine("1. Hawaiian");
			Console.WriteLine("2. Primavera");
			Console.WriteLine("3. Margherita");
			input = Console.ReadLine();

			switch (int.Parse(input))
			{
				case 1:
					director.MakePizza("Hawaiian");
					break;
				case 2:
					director.MakePizza("Primavera");
					break;
				case 3:
					director.MakePizza("Margherita");
					break;
				default:
					break;
			}

			Pizza pizza = builder.GetPizza();
			Console.WriteLine(pizza.Name + " " + pizza.Cost + "$");

			foreach (string ingredient in pizza.Igredients)
			{
				Console.WriteLine(ingredient);
			}
		}
	}
}
