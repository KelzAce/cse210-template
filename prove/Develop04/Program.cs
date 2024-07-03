using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            ShowMenu();
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter duration in seconds for breathing activity");
                int duration = int.Parse(Console.ReadLine());
                Activity activity = new BreathingActivity(duration);
                activity.Start();
            }
            else if (choice == "2")
            {
                Console.Write("Enter duration in seconds for reflection activity");
                int duration = int.Parse(Console.ReadLine());
                Activity activity = new ReflectionActivity(duration);
                activity.Start();
            }
            else if (choice == "3")
            {
                Console.Write("Enter duration in seconds for Listing activity");
                int duration = int.Parse(Console.ReadLine());
                Activity activity = new ListingActivity(duration);
                activity.Start();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Exiting the program, Goodbye.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, Please try again");
            }
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("Welcome to the mindfulness app");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Exit");
        Console.Write("Enter your choice (1-4)");
    }
}