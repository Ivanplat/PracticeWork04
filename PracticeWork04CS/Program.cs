using System;

namespace PracticeWork04CS
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalsFabric.Instance();
            Random random = new Random();
            for (int i = 0; i < random.Next(1, 100); i++)
            {
                int r = random.Next(0, 4);
                AnimalsFabric.Instance().CreateAnimal(r).Speak();
            }
            AnimalsFabric.Instance().AnimalsCount();
        }
    }
}
