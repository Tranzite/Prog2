using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktion
{
    class Shark : Animal
    {
        public Shark()
        {
            NumberOfLimbs = 5;

        }
        public override void Breathe()
        {
            Console.WriteLine("Shark goes blub blub");
        }

        public override void Eat()
        {
            Console.WriteLine("Shark is heckin eating! MonkaS");
        }

        public override void Rest()
        {
            Console.WriteLine("Shark is autopiloting 4Head");
        }
    }
}
