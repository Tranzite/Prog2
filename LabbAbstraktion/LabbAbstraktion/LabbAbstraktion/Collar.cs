using System;
using System.Collections.Generic;
using System.Text;

namespace LabbAbstraktion
{
    class Collar : Accesories
    {
        public Collar()
        {
            Cost = "20KR";
        }


        public override void Color()
        {
            Console.WriteLine("The Collar is blue :)");
        }

        public override void Idfk()
        {
            Console.WriteLine("This Collar is idfk I guess");
        }

    }
}
    /*
     *    class Cat : Animal
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
    */

