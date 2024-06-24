using System;
using System.Collections.Generic;
using System.IO;

public class Journal()
{
    public List<JournalEntry> entries = new List<JournalEntry>();
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person i Interacted with today?",
        "What was the best part of my day?",
        "How did i see the hand of the Lord in my life today?",
        "What was the strongest emotion i felt today?",
        "If i had one thing i could do over today, what would it be?",
    };

    public void WriteNewEntry()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        entries.Add(new JournalEntry {Prompt = prompt, Response = response, Date = DateTime.Now});
    }

    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveJournalToFile()
    {
        Console.Write("Enter filename to save journal: ");
        string filename = Console.ReadLine();

        using (StreamWriter sw = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                sw.WriteLine(entry.Date);
                sw.WriteLine(entry.Prompt);
                sw.WriteLine(entry.Response);
                sw.WriteLine("---");
            }
        }

        Console.WriteLine("Journal saved to " + filename);
    }

    public void LoadJournalFromFile()
    {
        Console.Write("Enter filename to load journal: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            entries.Clear();
            string[] lines = File.ReadAllLines(filename);
            for (int i = 0; i < lines.Length; i += 4)
            {
                DateTime date = DateTime.Parse(lines[i]);
                string prompt = lines[i + 1];
                string response = lines[i + 2];
                entries.Add(new JournalEntry {Date = date, Prompt = prompt, Response = response});
            }
            Console.WriteLine("Journal loaded from " + filename);
        }
         else
        {
        Console.WriteLine("File not found. ");
        }
    }

    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("\nMenu: ");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to filename");
            Console.WriteLine("4. load journal from filename");
            Console.WriteLine("5. Exit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
            case "1":
                WriteNewEntry();
                break;
            case "2":
                DisplayJournal();
                break;
            case "3":
                SaveJournalToFile();
                break;
            case "4":
                LoadJournalFromFile();
                break;
            case "5":
                return;
            default:
                Console.WriteLine("Invalid choice.  Please try again");
                break;
            }
        }
    }
}


