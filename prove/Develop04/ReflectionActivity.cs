using Microsoft.VisualBasic;

class ReflectionActivity : Activity
{
    private static readonly List<string> Prompts = new List<string>
    {
        "Think of a time when you stood up for someone else. ",
        "Think of a time when you did something really difficult. ",
        "Think of a time when you helped someone in need. ",
        "Think of a time when you did something trely selfless. ",
    };

    private static readonly List<string> Questions = new List<string>
    {
        "Why was the experience meaningful to you? ",
        "Have you ever done anything like this before? ",
        "How did you get started? ",
        "How did you feel when it was complete? ",
        "What made this time different from other time when you were not as successful? ",
        "What is your favourite thing about this experience? ",
        "WHat could you learn from this experience that applies to other situation? ",
        "What did you learn about yourself through this experience? ",
        "How can you keep this experience in mind in the future? ",
    };

    public ReflectionActivity(int duration) : base(duration){}

    protected override void PerformActivity()
    {
        Random rand = new Random();
        string selectedPrompt = Prompts[rand.Next(Prompts.Count)];
        Console.WriteLine(selectedPrompt);

        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            string question = Questions[rand.Next(Questions.Count)];
            Console.WriteLine(question);
            ShowAnimation();
            Thread.Sleep(3000); //Pause for three seconds
        }
    }
}