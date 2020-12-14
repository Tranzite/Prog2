using Komposition.Abstract;
using Komposition.Concretes;
using Komposition.Interface;
using System;
using System.Collections.Generic;

namespace Komposition
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            var goodBoi = new Dog();
            goodBoi.Color = "Grey";
            goodBoi.NumberOfLimbs = 4;

            var birb = new Bird();
            birb.Color = "Red and green";
            birb.NumberOfLimbs = 4;


            animals.Add(goodBoi);
            animals.Add(birb);

            var birds = new List<IBird>();
            var dogs = new List<IDog>();
           

            foreach (var animal in animals)
            {
                Console.WriteLine("This animal is "+ animal.Color);
                Console.WriteLine("This animal has " + animal.NumberOfLimbs);

                if(animal is Dog dog)
                {
                    dogs.Add(dog);
                   
                }
                else if(animal is Bird bird)
                {
                    birds.Add(bird);
                }
            }
            foreach (var doggo in dogs)
            {
                doggo.Eat();
                doggo.Rest();
                doggo.Move();
            }
            foreach (var fowl in birds)
            {
                fowl.Eat();
                fowl.Rest();
                fowl.Move();
                fowl.Fly();
            }



        }
    }
}
