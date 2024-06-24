using System;
using System.IO;

public class Journal()
{
    public List<Entry> prompts = new List<Entry>();

    public void Display()
    {
        string fileName = "myFile.txt";


        Console.WriteLine("Prompt: ");

        foreach (Entry prompt in prompts)
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                outputFile.WriteLine("This will be the first line in the file");
            }
        }
    }
}