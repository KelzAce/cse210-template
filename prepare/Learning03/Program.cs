using System;

class Program
{
    static void Main(string[] args)
    {

        int numerator = 3;
        int denominator = 4;


        Fraction test = new Fraction();
        Fraction test1 = new Fraction(numerator);
        Fraction test2 = new Fraction(numerator,denominator);

        double decimalValue = Fraction.GetDecimalValue(1,2);
        int _numerator = test1.GetTop(numerator);

        Console.WriteLine($"{decimalValue}");
        Console.WriteLine($"{_numerator}");
    }
}