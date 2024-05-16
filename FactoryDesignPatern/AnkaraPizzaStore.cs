namespace FactoryDesignPatern
{
    class AnkaraPizzaStore : PizzaStore
    {
        protected override IPizza CreatePizza(string type)
        {
            return type switch
            {
                "cheese" => new CheesePizza(),
                "mixed" => new MixedPizza(),
                null => throw new ArgumentException("Invalid Pizza Type")
            };
        }
    }
}
