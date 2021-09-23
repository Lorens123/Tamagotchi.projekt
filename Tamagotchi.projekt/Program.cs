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

            while (lama.GetAlive())
            {
                Console.WriteLine("Vad vill du göra med " + lama.name + " ? ");

                Console.WriteLine("1. Lär " + lama.name + " ett nytt ord?");
                Console.WriteLine("2. Hälsa på " + lama.name + " ?");
                Console.WriteLine("3. Mata " + lama.name + " ?");
                Console.WriteLine("4. Göra ingenting?");



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
                    lama.Tick();


                }

                if (val == 2)
                {
                    lama.Hi();
                    Console.WriteLine("Hejsan " + lama.name);
                    lama.Tick();
                }
                if (val == 3)
                {
                    lama.Feed();
                    Console.WriteLine("Mums!");
                    lama.Tick();
                }
                if (val == 4)
                {
                    lama.Tick();
                    Console.WriteLine(":(");

                }

            }

            Console.ReadLine();

        }
    }
}
