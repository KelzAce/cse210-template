using System;

public class Journal()
{
    public List<Entry> prompt = new List<Entry>();

    public void Display()
    {
        Console.WriteLine($"{prompt}");
    }
}