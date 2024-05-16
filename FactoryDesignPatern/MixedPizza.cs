namespace FactoryDesignPatern
{
    public class MixedPizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("Karışık Pizza Pişirildi");
        }

        public void Cut()
        {
            Console.WriteLine("Karışık Pizza Dilimlendi");

        }

        public void Prepare()
        {
            Console.WriteLine("Karışık Pizza Hazırlandı");

        }
    }
}
