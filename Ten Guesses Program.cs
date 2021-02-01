using System;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Higher Lower Game");

        Console.WriteLine("Guess the random number!");
        string inputString = Console.ReadLine();
        int userGuess = int.Parse(inputString);

        Random random = new Random();

        int secretNumber = random.Next(1, 101);
        

        while (userGuess != secretNumber)
        {
            if (userGuess > secretNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (userGuess < secretNumber)
            {
                Console.WriteLine("Higher");
            }
        }

        Console.WriteLine("Congratulations, you win!");
    }
}