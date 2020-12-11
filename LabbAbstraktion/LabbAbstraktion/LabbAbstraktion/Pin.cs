using System;
using System.Collections.Generic;
using System.Text;

namespace LabbAbstraktion
{

    class Pin : Accesories
    {
        public Pin()
        {
            Cost = "5KR";
        }


        public override void Color()
        {
            Console.WriteLine("The Pin is Red :)");
        }

        public override void Idfk()
        {
            Console.WriteLine("This Pin is not idfk, sweet!");
        }
    }

        
}
