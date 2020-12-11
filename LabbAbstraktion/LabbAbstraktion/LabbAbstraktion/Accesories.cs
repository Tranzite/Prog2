using System;
using System.Collections.Generic;
using System.Text;

namespace LabbAbstraktion
{
    abstract class Accesories
    {

        public String Cost { get; set; } // Både Animal och Accessories skall innehålla 2 egenskaper samt 2 beteenden vardera.

        public abstract void Color(); //definerat en metod utan innehåll, skall finnas i alla klasser som ärvs av "Animal"

        public abstract void Idfk();

    }
}
