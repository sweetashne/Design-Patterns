using System.Collections.Generic;

namespace BuilderDesignPattern
{
	public class PizzaBuilder : IPizzaBuilder
	{
		public string Name { get; set; }

		public ICollection<string> Ingredients = new List<string>();

		public Pizza GetPizza()
		{
			if (Name == "Hawaiian")
			{
				Ingredients.Add("Pineapple");
				Ingredients.Add("Cheese");
				Ingredients.Add("Ham");
				Ingredients.Add("Pepper");
				Ingredients.Add("Sauce");
				return new Pizza(Name, Ingredients, 60);
			}
			else if(Name == "Primavera")
			{
				Ingredients.Add("Pineapple");
				Ingredients.Add("Pepper");
				Ingredients.Add("Brocoli");
				Ingredients.Add("Chicken breast");
				Ingredients.Add("Sauce");
				Ingredients.Add("Tomato");
				Ingredients.Add("Lettuce");
				return new Pizza(Name, Ingredients, 50);
			}
			else if(Name == "Margherita")
			{
				Ingredients.Add("Oregano");
				Ingredients.Add("Cheese");
				Ingredients.Add("Sauce");
				return new Pizza(Name, Ingredients, 30);
			}
			else return null;
		}
	}
}
