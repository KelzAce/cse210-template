using System;

public class Entry()
{
   public string _date;
   public string _promptedText;
   public string _entryText;

   public void Display()
   {
        Console.Write($"Enter Today's Date: {_date}");
        Console.WriteLine($"promptedText: {_promptedText}");
        Console.WriteLine($"EntryText: {_entryText}");
   }
}