using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


public class Scripture
{
    private ScriptureReference _reference;
    private List<Word> words;

    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;
        words = text.Split().Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count = 3)
    {
      var visibleWords = words.Where(words => !words._isHidden).ToList();
      if (visibleWords.Count > 0)
      {
        var random = new Random();
        var wordsToHide = visibleWords.OrderBy(x => random.Next()).Take(Math.Min(count, visibleWords.Count)).ToList();
        wordsToHide.ForEach(word => word.Hide());
      }

    }

    public string GetDisplayText()
    {
      var wordsTest = string.Join(" ", words);
      return $"{_reference}\n{wordsTest}";
    }

    public bool isCompletelyHidden()
    {
       return words.All(words => words._isHidden);
    }
}