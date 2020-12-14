using Komposition.Abstract;
using Komposition.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Komposition.Concretes
{
    class Bird : Animal, IBird
    {
        public void Eat()
        {
            Console.WriteLine("Bird go eat seed");
        }

        public void Fly()
        {
            Console.WriteLine("Bird is flying ");
        }

        public void Move()
        {
            Console.WriteLine("Bird is hopping");
        }

        public void Rest()
        {
            Console.WriteLine("Bird go zzzz");
        }
    }
}
