using System;

class Program
{
    static void Main(string[] args)
    {
        // Create base assignment object

        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSummary());


        //derived class assignments
        MathAssignment a2 = new MathAssignment("Lilian Benedict", "Fraction", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Jonah Godspower", "African History", "The Story about Slavery");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}