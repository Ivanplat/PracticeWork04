using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeWork04CS
{
    class AnimalsFabric
    {
        public static AnimalsFabric Instance()
        {
            if(instance == null)
            {
                instance = new AnimalsFabric();
            }
            return instance;
        }
        public IAnimals CreateAnimal(int ID)
        {
            IAnimals lAnimal;
            switch (ID)
            {
                case 0: { lAnimal = new Cat(); _Cats.Add((Cat)lAnimal); } break;
                case 1: { lAnimal = new Dog(); _Dogs.Add((Dog)lAnimal); } break;
                case 2: { lAnimal = new Humster(); _Humsters.Add((Humster)lAnimal); } break;
                case 3: { lAnimal = new Hippo(); _Hippos.Add((Hippo)lAnimal); } break;
                default: { lAnimal = new Cat(); _Cats.Add((Cat)lAnimal); } break;
            }
            return lAnimal;
        }
        public void AnimalsCount()
        {
            if(_Cats.Count > 0)
            {
                Console.WriteLine($"Cats: {_Cats.Count}");
            }
            else
            {
                Console.WriteLine("Cats: 0");
            }
            if (_Dogs.Count > 0)
            {
                Console.WriteLine($"Cats: {_Dogs.Count}");
            }
            else
            {
                Console.WriteLine("Dogs: 0");
            }
            if (_Humsters.Count > 0)
            {
                Console.WriteLine($"Cats: {_Humsters.Count}");
            }
            else
            {
                Console.WriteLine("Humsters: 0");
            }
            if (_Hippos.Count > 0)
            {
                Console.WriteLine($"Cats: {_Hippos.Count}");
            }
            else
            {
                Console.WriteLine("Hippos: 0");
            }
        }
        private AnimalsFabric() 
        {
       _Cats = new List<Cat>();
       _Dogs = new List<Dog>();
       _Humsters = new List<Humster>();
       _Hippos = new List<Hippo>();
    }
        ~AnimalsFabric() { }

        private List<Cat> _Cats;
        private List<Dog> _Dogs;
        private List<Humster> _Humsters;
        private List<Hippo> _Hippos;

        private static AnimalsFabric instance;
    }
}
