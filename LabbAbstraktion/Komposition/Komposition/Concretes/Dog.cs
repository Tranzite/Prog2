using Komposition.Abstract;
using Komposition.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Komposition.Concretes
{
    class Dog : Animal, IDog
    {
        public void Eat()
        {
            Console.WriteLine("Heckin Dog is munchin");
        }

        public void Move()
        {
            Console.WriteLine("Dog is moving heckin fast!");
        }

        public void Rest()
        {
            Console.WriteLine("Heckin dog is resting");
        }
    }
}
