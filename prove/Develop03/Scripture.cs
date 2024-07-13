using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ScriptureMemorization
{
  public class Scripture
{
  public Reference Reference {get; private set;}
  private List<Word> Words {get; set;}

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void HideRandomWords()
    {
     Random random = new Random();
     int wordsToHide = Math.Min(3, Words.Count(w => !w.IsHidden));

     for (int i = 0; i < wordsToHide; i++)
     {
      List<Word> visibleWords = Words.Where(w => !w.IsHidden).ToList();
      if (visibleWords.Count == 0) break;

      visibleWords[random.Next(visibleWords.Count)].Hide();
     }
    }

    public bool AllWordsHidden()
    {
      return Words.All(w => w.IsHidden);
    }

    public override string ToString()
      {
        return $"{Reference}\n{string.Join(' ', Words)}";
      }
    }
}
