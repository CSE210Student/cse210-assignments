using System;

class Program
{
    static void Main(string[] args)
    {
        string play = "";
        do
        {
            Random randomGenerator = new Random();
            int magic = randomGenerator.Next(1, 51);

            int guess = -5;
            int count = 0;

            while (guess != magic)
            {
                Console.Write("What is your guess? ");
                string userGuess = Console.ReadLine();
                guess = int.Parse(userGuess);

                if (guess > magic)
                {
                    Console.WriteLine("Lower");
                    count += 1;
                }
                else if (guess < magic)
                {
                    Console.WriteLine("Higher");
                    count += 1;
                }
                else
                {
                    Console.WriteLine("You got it! Way to go superstar!");
                    count += 1;
                }
            }

            Console.WriteLine($"Total Guess Count: {count}");
            Console.Write("Would you like to play again? YES NO ");
            play = Console.ReadLine();
        } while (play != "NO");
    }
}