namespace Design_Patterns
{
	interface IPizzaBuilder
	{
		string Name { get; set; }

		Pizza GetPizza();
	}
}
