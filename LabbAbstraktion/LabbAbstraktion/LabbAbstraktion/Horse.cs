using System;
using System.Collections.Generic;
using System.Text;

namespace LabbAbstraktion
{
    class Horse : Animal
    {
        public Horse()
        {
            NumberOfLimbs = 4;
        }
        public override void Move()
        {
            Console.WriteLine("The horse is galloping");
        }

        public override void Eat()
        {
            Console.WriteLine("The horse is munching");
        }

        public override void Sleep()
        {
            Console.WriteLine("The horse is snoring");
        }
    }
}
