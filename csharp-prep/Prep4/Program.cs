using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       Compute();
    }

    static void Compute()
    {
        List<double> numbers = new List<double>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished: ");

        while (true)
        {
            Console.Write("Enter number: ");
            double num = Convert.ToDouble(Console.ReadLine());

            if (num == 0)
            {
                break;
            }

            numbers.Add(num);
        }

        //compute the sum of the numbers
        double totalSum = 0;
        foreach (double number in numbers)
        {
            totalSum += number;
        }
        
        //compute the average of the number
        double average = 0;
        if (numbers.Count > 0)
        {
            average = totalSum / numbers.Count;
        }

        //Print the sum
        Console.WriteLine($"The sum is: {totalSum}");

        //find the maximum number in the list
        double maxNumber = double.MinValue;
        foreach (double number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }

        Console.WriteLine($"The sum is: {totalSum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNumber}");
    }
}