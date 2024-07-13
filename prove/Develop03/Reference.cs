using System;

namespace ScriptureMemorization
{
  public class Reference
 {
    public string Book {get; private set;}
    public int Chapter {get; private set;}
    public int StartVerse {get; private set;}
    public int EndVerse {get; private set;}
    public bool IsSingleVerse => StartVerse == EndVerse;


    public Reference(string reference)
    {
       var parts = reference.Split(' ');
       Book = parts[0];
       var chapterAndVerses = parts[1].Split(':');
       Chapter = int.Parse(chapterAndVerses[0]);
       var verses = chapterAndVerses[1].Split('_');
       StartVerse = int.Parse(verses[0]);
       EndVerse = verses.Length > 1 ? int.Parse(verses[1]) : StartVerse;
    }
    public override string ToString()
    {
      return IsSingleVerse ? $"{Book} {Chapter}:{StartVerse}" : $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
    }
 
}
}
