using System;
using System.Collections.Generic;

namespace Abstraktion
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Animal> animals = new List<Animal>();

            var dog = new Dog();
            dog.Color = "brown";

            var shark = new Shark();
            shark.Color = "blue";

            animals.Add(dog);
            animals.Add(shark);

            foreach (var animal in animals)
            {
                animal.Breathe();
                animal.Eat();
                animal.Rest();

                if (animal is Shark tempShark)
                {
                    tempShark.Swim();
                }
            }
        }
    }
}
