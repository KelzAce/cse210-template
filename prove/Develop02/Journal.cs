using System;

public class Journal()
{
    public List<Entry> prompts = new List<Entry>();

    public void Display()
    {
        Console.WriteLine("Prompt: ");

        foreach (Entry prompt in prompts)
        {
            prompt.Display();
        }
    }
}