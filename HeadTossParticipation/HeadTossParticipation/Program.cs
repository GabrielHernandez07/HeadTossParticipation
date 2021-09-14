using System;

namespace HeadTossParticipation
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Heads = 1;
            const int Tails = 2;

            Console.WriteLine("Pick Heads or Tails >>");
            string result = Console.ReadLine();

            Console.WriteLine("Coin fell on");
            Random rand = new Random();
            int randValue = rand.Next(1, 3);

            if (randValue == 1)
            {
                Console.WriteLine("Heads");
            }
            else
            {
                Console.WriteLine("Tails");
            }
            int resultAsNumber = 0;

            if (result == "Heads")
            {
                resultAsNumber = Heads;
            }
            else if (result == "Tails")
            {
                resultAsNumber = Tails;
            }
            else;

            if (resultAsNumber == randValue ) 
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
