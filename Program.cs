using System;

namespace MadLib
{
    class Program
    {
        static void Main()
        {
            // lag variabla med ord

            string Creature;
            string Luminous;
            string Ghastly;
            string Spectral;
            string Farmer;
            string Hound;

            // Variabel for ferdig historie:
            string Story;


            // skriv ut ein intro

            Console.WriteLine("Hei, og velkommen til dette madlib spelet");
            Console.WriteLine("Du kan velge mellom desse orda:");
            

            // be spelar skrive inn ord
            Console.Write("Vennligst skriv inn eit ord: ");
            Creature = Console.ReadLine();

            Console.Write("Vennligst skriv inn eit ord: ");
            Luminous = Console.ReadLine();

            Console.Write("Vennligst skriv inn eit ord: ");
            Ghastly = Console.ReadLine();

            Console.Write("Vennligst skriv inn eit ord: ");
            Spectral = Console.ReadLine();

            Console.Write("Vennligst skriv inn eit ord: ");
            Farmer = Console.ReadLine();

            Console.Write("Vennligst skriv inn eit ord: ");
            Hound = Console.ReadLine();


            // skriv ut ferdig historie

            Story = $"They all agreed that it was a huge {Creature}, {Luminous}, {Ghastly}, and {Spectral}." +
                $" I have cross-examined these men, one of them a hard-headed countryman, one a farrier, " +
                $"and one a moorland {Farmer}, who all tell the same story of this dreadful apparition, " +
                $"exactly corresponding to the {Hound} of the legend.";

            Console.WriteLine(Story);

            Console.ReadKey();





        }
    }
}
        
