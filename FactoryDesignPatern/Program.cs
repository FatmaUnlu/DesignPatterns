using FactoryDesignPatern;

PizzaStore ankaraPizzaStore = new AnkaraPizzaStore();
IPizza pizza = ankaraPizzaStore.OrderPizza("cheese");
Console.WriteLine(pizza);
Console.ReadKey();