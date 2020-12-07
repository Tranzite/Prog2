using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktion
{
    abstract class Animal
    {
        public int NumberOfLimbs { get; set; }

        public String Color{ get; set; } //prop tab tab för detta:         public int MyProperty { get; set; }

        public abstract void Breathe(); //definerat en metod utan innehåll, skall finnas i alla klasser som ärvs av "Animal"

        public abstract void Rest();

        public abstract void Eat();
        

        
    }
}
