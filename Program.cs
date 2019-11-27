using System;

namespace Game
{

    static class MadLib
    {
        // lag variabla med ord

        static string[] Words = { "Creature", "Luminous", "Ghastly", "Spectral",
            "Farmer", "Hound" };

        static string[] Input = { "ord", "ord2", "ord3", "ord4", "ord5", "ord6" };
         
         

        // Variabel for ferdig historie:
        static string Story;

        public static void Run()
        {
            Intro();
            PlayerWords();
            StoryPrint();
        }

            static void Intro()
            {
                // skriv ut ein intro
                Console.WriteLine("Hei, og velkommen til dette madlib spelet");
                Console.WriteLine("Du kan velge mellom desse orda:");
            }
            

            static void PlayerWords()
            {
                // be spelar skrive inn ord
               for (int i = 0; i < Words.Length; i++)
               {
                Console.Write($"Skriv inn {Input[i]}:");
                Words[i] = Console.ReadLine();
               
               }
            }
            

            static void StoryPrint()
            {
                // skriv ut ferdig historie
                Story = $"They all agreed that it was a huge {Input[0]}, {Words[1]}, {Words[3]}, and {Words[4]}." +
                    $" I have cross-examined these men, one of them a hard-headed countryman, one a farrier, " +
                    $"and one a moorland {Words[5]}, who all tell the same story of this dreadful apparition, " +
                    $"exactly corresponding to the {Words[6]} of the legend.";

                Console.WriteLine(Story);

                Console.ReadKey();

            }
    }


    class Program
    {
        

        static void Main()
        {
            MadLib.Run();
        }
    }

}
        
