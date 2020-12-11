using System;
using System.Collections.Generic;
using System.Text;

namespace LabbAbstraktion
{
    class Cat : Animal
    {
        public Cat()
        {
            NumberOfLimbs = 4;
        }
        public override void Move()
        {
            Console.WriteLine("The cat moves swiftly!");
        }

        public override void Eat()
        {
            Console.WriteLine("The cat is licking the bowl!");
        }

        public override void Sleep()
        {
            Console.WriteLine("The cat is purring!");
        }
    }
}
