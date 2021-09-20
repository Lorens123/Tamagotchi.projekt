using System.Data;
using System.ComponentModel;
using System.Net;
using System;

namespace Tamagotchi.projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Tamagotchi lama = new Tamagotchi();

            Console.WriteLine("Ge din lamagotchi ett namn:");
            lama.name = Console.ReadLine();
            lama.Teach("Haj");
            Console.WriteLine("Vad vill du göra med " + lama.name + " ? ");

            Console.WriteLine("1. Lär den ett nytt ord?");
            Console.WriteLine("2. Hälsa på den?");
            Console.WriteLine("3. Mata den?");
            Console.WriteLine("4. Göra ingenting?");
            //1. När spelaren valt en handling, kör motsvarande metod och fråga sedan igen.
            //2. Varje gång spelaren gör ett val så körs också Tick.
            //3. Om tamagotchin är död avslutas spelloopen.


            int val = int.Parse(Console.ReadLine());

            if (val == 0 || val > 4)
            {
                Console.WriteLine("Fel inmatning!");
            }

            if (val == 1)
            {
                Console.WriteLine("Vilket ord?");
                string ord = Console.ReadLine();

                lama.Teach(ord);

            }

            if (val == 2)
            {
                lama.Hi();
                Console.WriteLine("Hejsan " + lama.name);
            }
            if (val == 3)
            {
                lama.Feed();
                Console.WriteLine("Mums!");
            }
            if (val == 4)
            {
                lama.Tick();
                Console.WriteLine(":(");


            }


            Console.ReadLine();

        }
    }
}
