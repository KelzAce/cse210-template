using System;

public class JournalEntry()
{
  public string Prompt;
  public string Response;
  public DateTime Date;

    public override string ToString()
    {
      return $"Date: {Date}\nPrompt: {Prompt}\n Response: {Response}\n";
    }
}