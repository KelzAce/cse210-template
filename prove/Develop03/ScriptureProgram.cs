using System;

public class ScriptureProgram
{
    private List<Scripture> scriptures;
    public ScriptureProgram(List<Scripture> _scriptures)
    {
        scriptures = _scriptures;
    }

    public void Run()
    {
        foreach (var scripture in scriptures)
        {
            while (true)
            {
                ClearConsole();
                Console.WriteLine(scripture);
                Console.WriteLine("\nPress Enter to continue or type 'quit' to exit: ");
                var userInput = Console.ReadLine().Trim().ToLower();
                if (userInput == "quit")
                {
                    return;
                }
                scripture.HideRandomWords();
                if (scripture.isCompletelyHidden())
                {
                    ClearConsole();
                    Console.WriteLine(scriptures);
                    Console.WriteLine("\nAll words are Hidden.  Moving to the next scripture");
                    break;
                }
            }
        }
    }

    private void ClearConsole()
    {
        Console.Clear();
    }
}