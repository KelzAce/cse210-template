using System;


public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;


    public Reference(string book, int chapter, int startverse, int endVerse)
    {
       _book = book;
       _chapter = chapter;
       _verse = startverse;
       _endVerse = endVerse;
    }
    public string GetDisplayText()
    {
      return "";
    }
 
}