using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please input your grade percentage:  ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        // string letter;

        if (grade >= 90 ) 
            {
                string letter = "A";
                
                Console.WriteLine($"Your letter grade is, {letter}");
                  if (grade >= 90) 
                 {
                    Console.WriteLine($"Congratulations, You passed");
                 }
            }
        else if (grade >= 80)
            {
                string letter = "B";
                 Console.WriteLine($"Your letter grade is, {letter}");
                   if (grade >= 80) 
                 {
                    Console.WriteLine($"Congratulations, You passed");
                 }
            }
        else if (grade >= 70)
            {
                string letter = "C";
                 Console.WriteLine($"Your letter grade is, {letter}");
                 if (grade >= 70) 
                 {
                    Console.WriteLine($"Congratulations, You passed");
                 }
            }
        else if (grade >= 60)
            {
                 string letter = "D";
                 Console.WriteLine($"Your letter grade is, {letter}");
                   if (grade >= 60) 
                        {
                         Console.WriteLine($"Please do better next time, You didnt meet the cut off point");
                        }
            }
        else if (grade < 60)
            {
                string letter = "F";
                 Console.WriteLine($"Your letter grade is, {letter}");
                  if (grade < 60) 
                        {
                         Console.WriteLine($"Please do better next time, You didnt meet the cut off point");
                        }
            }

        else 
            {
                Console.WriteLine("You have reached the end of this program!");
            }
    }
}