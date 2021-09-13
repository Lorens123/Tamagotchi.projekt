using System;

namespace Tamagotchi.projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Tamagotchi lama = new Tamagotchi();

            lama.name = Console.ReadLine();
            lama.Teach("Haj");
            lama.Hi();
            lama.PrintStats();

            Console.WriteLine("Hello World!");
            Console.ReadLine();

        }
    }
}
