using System;
using System.Collections.Generic;
using System.Text;

namespace LabbAbstraktion
{
    class Leash : Accesories
    {
        public Leash()
        {
            Cost = "40KR";
        }


        public override void Color()
        {
            Console.WriteLine("The Leash is bajsbrun :)");
        }

        public override void Idfk()
        {
            Console.WriteLine("This Leash is heckin good goodjob!");
        }
    }
}
