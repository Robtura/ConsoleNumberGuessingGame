using System;

namespace ConsoleNumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winNum = r.Next(0, 100);

            bool win = false;

            do
            {
                Console.WriteLine("Guess a number inbetween 0 and 100:");
                string number = Console.ReadLine();

                int i = int.Parse(number);

                if (i > winNum)
                {
                    Console.WriteLine("Too high! Guess lower...");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("Too low! Guess higher...");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("You Win!");
                    win = true;
                }
                Console.WriteLine();
            } while (win == false);
            Console.WriteLine("Thank you for playing the game!");
            Console.WriteLine("Press any key to finish");
            Console.ReadKey(true);
        }
    }
}
