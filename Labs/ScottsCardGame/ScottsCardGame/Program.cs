using System;

namespace ScottsCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create new pack

            int[] newPack = new int[52];

            for (int i = 0; i < newPack.Length; i++)
            {
                newPack[i] = i;
            }

            printPack(newPack);
            Console.WriteLine("-----Shuffle & Deal-----");
            //2. Shuffle Deck

            Random r = new Random();
            for (int i = 0; i < newPack.Length; i++)
            {
                //pick a random number from 0-51
                int rNum = r.Next(52);

                //swap i for random number

                int temp = newPack[i];
                newPack[i] = newPack[rNum];
                newPack[rNum] = temp;
            }

            //3. Deal/print deck
            printPack(newPack);
        }

        private static void printPack(int[] newPack)
        {
            string[] suits = { "Clubs", "Diamond", "Hearts", "Spades" };
            string[] values = { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };

            foreach(int i in newPack)
            {
                Console.WriteLine($"{values[i%13]} of {suits[i/13]}");
            }
        }
    }
}
