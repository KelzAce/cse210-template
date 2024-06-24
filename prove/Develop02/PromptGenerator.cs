using System;

public class PromptGenerator()
{
    public List<Entry> _prompts = new List<Entry>();

        public void Display()
        {
            Console.WriteLine($"prompt: {_prompts}");

            foreach (Entry prompt in _prompts)
            {
              Display();
            }
        }
}