using System;

public class ScriptureReference
{
    public string Book;
    public int _chapter;
    public int _startverse;

    public int? _endVerse;

    public ScriptureReference(string book, int chapter, int startverse, int? endverse = null)
    {
        Book = book;
        _chapter = chapter;
        _startverse = startverse;
        _endVerse = endverse;
    }

    public override string ToString()
    {
        if (_endVerse.HasValue)
        {
            return $"{Book} {_chapter}: {_startverse}-{_endVerse}";
        }else
        {
            return $"{Book} {_chapter}:{_startverse}";
        }
    }
}