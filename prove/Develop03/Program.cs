using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ScriptureMemorization
{
    class Program
{
    static void Main(string[] args)
    {
        //path to scripture file
        string filePath = "scriptures.txt";


        //load scriptures from file
        var scriptures = LoadScriptures("scripture.txt");

        if (scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures found");
            return;
        }
        
        Random random = new Random();
        Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(selectedScripture);
            Console.WriteLine("\nPress Enter to hide a few words or type 'quit' to exit");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            selectedScripture.HideRandomWords();
            if (selectedScripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine("All words are hidden.  Well done!");
                break;
            }
        }
    }

    static List<Scripture> LoadScriptures(string filePath)
    {
        var scriptures = new List<Scripture>();

        if (File.Exists(filePath))
        {
            var lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i+=2)
            {
                if (i + 1 < lines.Length)
                {
                    scriptures.Add(new Scripture(new Reference(lines[i]), lines[i + 1]));
                }
            }
        }

        return scriptures;
    }
}
}
