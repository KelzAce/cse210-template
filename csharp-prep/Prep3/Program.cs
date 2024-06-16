using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;

        while (playAgain) 
        {
            PlayGame();
            AskToPlayAgain();
        }

        Console.WriteLine("Thanks for playing again, Goodbye!");

        static void PlayGame()
        {
            Console.WriteLine("Welcome to the Guess number Game.");

            Console.Write("Input a magic number: ");
            string userInput = Console.ReadLine();
            int magicNumber = int.Parse(userInput);

            Console.Write("Guess the magic number: ");
            string input = Console.ReadLine();
            int userGuess = int.Parse(input);

            while (userGuess != magicNumber)
            {
                Console.Write("Please take another guess: ");
                string newinput = Console.ReadLine();
                int guess = int.Parse(newinput);

                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher! ");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You guessed the magic number {magicNumber}");
                        AskToPlayAgain();
                        PlayGame();
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