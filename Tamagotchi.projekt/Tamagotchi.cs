using System.Collections.Generic;
using System;

namespace Tamagotchi.projekt
{
    public class Tamagotchi
    {
        int x;
        int y;
        int hunger = 0;
        int boredom = 0;
        List<string> words = new List<string>();
        bool isAlive = true;
        Random generator = new Random();
        public string name;





        public void Feed()
        {
            hunger++;
        }

        public void Hi()
        {
            int i = generator.Next(words.Count);
            Console.WriteLine(words[i]);
            ReduceBoredom();
        }

        public void Teach(string word)
        {


            words.Add(word);
            ReduceBoredom();
        }

        public void Tick()
        {
            hunger++;
            boredom++;
            if (hunger > 10 || boredom > 10)
            {
                isAlive = false;
            }


        }

        public void PrintStats()
        {
            Console.WriteLine("Hunger:" + hunger);
            Console.WriteLine("Uttråkad: " + boredom);
            Console.WriteLine("Lever: " + isAlive);

        }

        public bool GetAlive()
        {
            return isAlive;

        }

        private void ReduceBoredom()
        {
            boredom--;
            if (boredom < 0)
            {
                boredom = 0;
            }


        }


    }
}