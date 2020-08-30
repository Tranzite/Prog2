using System;

namespace mata_in_namn_och_ålder
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hej detta är mitt program som vill veta vad din ålder och namn är!"); // Detta behövs nog inte förklaras.

            Console.WriteLine("Börja gärna med att skriva in ditt namn och sedan ålder");

            String name = Console.ReadLine(); // Console.ReadLine är att consolen ska mata in ett värde som i detta tillfället ska vara en string då ditt namn.

            Console.WriteLine("Hej " + name + " Hur gammal är du?");

            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Så du är " + age + " år gammal");

            bool deadOrNot = true;

            int dead = 100;
            if (age > dead)
            {
                    Console.WriteLine("Ledsen att säga det men du är fan död");
                
            }
            else
            {
                Console.WriteLine("Grattis du är inte död än din jävel");
            }
            

        }
    }
}
