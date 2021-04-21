namespace BuilderDesignPattern
{
	interface IPizzaBuilder
	{
		string Name { get; set; }

		Pizza GetPizza();
	}
}
