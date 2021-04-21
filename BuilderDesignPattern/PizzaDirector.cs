namespace BuilderDesignPattern
{
	class PizzaDirector
	{
		private IPizzaBuilder _builder;
		
		public PizzaDirector(IPizzaBuilder builder)
		{
			_builder = builder;
		}

		public void MakePizza(string name)
		{
			_builder.Name = name;
		}
	}
}
