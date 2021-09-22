using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeWork04CS
{
    abstract class IAnimals
    {
        public abstract void Speak();
    }
    class Cat : IAnimals
    {
        public Cat()
        {
            Count++;
        }
        public override void Speak()
        {
            Console.WriteLine("Meow");
        }
        static int Count = 0;
    }
    class Dog : IAnimals
    {
        public Dog()
        {
            Count++;
        }
        public override void Speak()
        {
            Console.WriteLine("Haw");
        }
        static int Count = 0;
    }
    class Humster : IAnimals
    {
        public Humster()
        {
            Count++;
        }
        public override void Speak()
        {
            Console.WriteLine("Hmff");
        }
        static int Count = 0;
    }
    class Hippo : IAnimals
    {
        public Hippo()
        {
            Count++;
        }
        public override void Speak()
        {
            Console.WriteLine("AAAA");
        }
        static int Count = 0;
    }
}
