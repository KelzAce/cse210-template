using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var scriptures = LoadScriptureFromFile("scripture.txt");
        var program = new ScriptureProgram(scriptures);
        program.Run();
    }

    static List<Scripture> LoadScriptureFromFile(string filename)
    {
        var scriptures = new List<Scripture>();
        foreach (var line in File.ReadAllLines(filename))
        {
            var parts = line.Split('|');
            var reference = parts[0].Trim();
            var text = parts[1].Trim();

            var refParts = reference.Split(' ');
            var book = refParts[0];
            var chapterVerses = refParts[1].Split(':');
            var chapter = int.Parse(chapterVerses[0]);
            var verses = chapterVerses[1];

            if (verses.Contains('-'))
            {
                var verseRange = verses.Split('-');
                var startVerse = int.Parse(verseRange[0]);
                var endverse = int.Parse(verseRange[1]);
                var refObj = new ScriptureReference(book, chapter, startVerse);
                scriptures.Add(new Scripture(refObj, text));
            }
            else
            {
                var startVerse = int.Parse(verses);
                var refObj = new ScriptureReference(book, chapter, startVerse);
                scriptures.Add(new Scripture(refObj, text));
            }
        }

        return scriptures;
    }
}