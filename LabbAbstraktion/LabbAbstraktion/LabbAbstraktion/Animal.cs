using System;
using System.Collections.Generic;
using System.Text;

namespace LabbAbstraktion
{
   
        abstract class Animal
        {
            public int NumberOfLimbs { get; set; }

            public String Color { get; set; } //prop tab tab för detta: public int MyProperty { get; set; }

            public abstract void Move(); //definerat en metod utan innehåll, skall finnas i alla klasser som ärvs av "Animal"

            public abstract void Eat();

            public abstract void Sleep();



        }
    }
