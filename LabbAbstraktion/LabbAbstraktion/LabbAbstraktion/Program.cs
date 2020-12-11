using System;
using System.Collections.Generic;

namespace LabbAbstraktion
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Animal> animals = new List<Animal>();
            List<Accesories> accesories = new List<Accesories>();

            var cat = new Cat();
            cat.Color = "black";

            var horse = new Horse();
            horse.Color = "brown";

            var turtle = new Turtle();
            turtle.Color = "green";

            animals.Add(cat);
            animals.Add(horse);
            animals.Add(turtle);


            var collar = new Collar();

            var pin = new Pin();

            var leash = new Leash();

            accesories.Add(collar);
            accesories.Add(pin);
            accesories.Add(leash);

            foreach (var animal in animals)
            {
                animal.Move();
                animal.Eat();
                animal.Sleep();

            }
            foreach (var accesorie in accesories)
            {
                accesorie.Color();
                accesorie.Idfk();
            }
        }
    }
}
