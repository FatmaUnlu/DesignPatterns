namespace FactoryDesignPatern
{
    public class CheesePizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("Peynirli Pizza Pişirildi");
        }

        public void Cut()
        {
            Console.WriteLine("Peynirli Pizza Dilimlendi");

        }

        public void Prepare()
        {
            Console.WriteLine("Peynirli Pizza Hazırlandı");

        }
    }
}
