using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktion
{
    class Dog : Animal
    {
        public Dog()
        {
            NumberOfLimbs = 4;
        }
        public override void Breathe()
        {
            Console.WriteLine("Dog takes deep breath");
        }

        public override void Eat()
        {
            Console.WriteLine("Dog Is chowing! HECKHECK!");
        }

        public override void Rest()
        {
            Console.WriteLine("Dog is snoring, shh");
        }
    }
}
