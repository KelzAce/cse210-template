using System;

public class Fraction
{
    private int _top;
    private int _buttom;

    public Fraction()
    {
        _top = 1;
        _buttom = 1;

        Console.WriteLine($"{_top} / {_buttom}");
    }

    public Fraction(int wholenumner)
    {
       _top = wholenumner;
       _buttom = 1;

        Console.WriteLine($"{_top} / {_buttom}");
    }

    public Fraction(int up, int down)
    {
        _top = up;
        _buttom = down;

        Console.WriteLine($"{_top} / {_buttom}");
    }

    public int GetTop(int numerator)
    {
        return numerator;
    }

    public void SetTop(int numerator)
    {
        _top = numerator;
    }
    
    public int GetButtom()
    {
        return _buttom;
    }

    public void SetButtom(int denominator)
    {
        _buttom = denominator;
    }

    public string GetFractionString(string numerator, string denominator)
    {
        string _numerator = numerator;
        string _denominator = denominator;

        return $"{_numerator} / {_denominator}";
    }

    public static double GetDecimalValue(int _top, int _buttom)
    {
        return (double) _top / _buttom;
    }
}