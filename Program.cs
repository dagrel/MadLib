using System;

namespace MadLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("yes or no?");
            string answer = Console.ReadLine();

            if (answer == "yes")
            {
                Console.WriteLine("så bra, lez go");
            }
            else if (answer == "no")
            { 
                Console.WriteLine("too bad");
            }

            // heeeey
           
        }
    }
}
