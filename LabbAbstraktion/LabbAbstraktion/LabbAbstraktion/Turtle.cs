using System;
using System.Collections.Generic;
using System.Text;

namespace LabbAbstraktion
{
    class Turtle : Animal
    {
        public Turtle()
        {
            NumberOfLimbs = 4;
        }
        public override void Move()
        {
            Console.WriteLine("The turtle is moving slowly...");
        }

        public override void Eat()
        {
            Console.WriteLine("The turtle is eating slowly...");
        }

        public override void Sleep()
        {
            Console.WriteLine("The turtle is soundly asleep...");
        }
    }
}
