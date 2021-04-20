using System.Collections.Generic;

namespace Design_Patterns
{
	public class Pizza
	{
		public string Name { get; set; }
		public ICollection<string> Igredients { get; set; }
		public int Cost { get; set; }
		public Pizza(string name, ICollection<string> igredients, int cost)
		{
			Name = name;
			Igredients = igredients;
			Cost = cost;
		}
	}
}
