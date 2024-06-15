using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;

        while (playAgain) 
        {
            PlayGame();
             playAgain = AskToPlayAgain();
        }

        Console.WriteLine("Thanks for playing again, Goodbye!");

        static void PlayGame()
        {
            Random random = new Random();
            int magicNumber = random.Next(1, 101); //generates a random number between 1 and 100
            int userGuess = 0;

            Console.WriteLine("Welcome to the Guess number Game");
            Console.WriteLine("I'm thinking of a number between 1 and 100, can you guess it?");

            while (userGuess != magicNumber)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out userGuess))
                {
                    if (userGuess < magicNumber)
                    {
                        Console.WriteLine("Higher! ");
                    }
                    else if (userGuess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You guessed the magic number {magicNumber}");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }
        }

        static bool AskToPlayAgain()
        {
            Console.WriteLine("Do you want to play again (yes/no)");
            string response = Console.ReadLine().ToLower();
            return response == "yes" || response == "y";
        }
    }
}