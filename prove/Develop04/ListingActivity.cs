class ListingActivity : Activity
{
    private static readonly List<string> Prompts = new List<string>
    {
        "Who are people that you appreciate? ",
        "What are personal strength of yours? ",
        "Who are people that you have helped this week? ",
        "When have you felt the HolyGhost this month? ",
        "Who are some of your personal heros? ",
    };

    public ListingActivity(int duration) : base(duration){}

    protected override void PerformActivity()
    {
        for (int i = 3; i > 0; i--)
        {
            Console.Write("i");
            Thread.Sleep(1000);
        }

        Console.WriteLine("Go!");

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        List<string> items = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter item: ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
        }

        Console.WriteLine($"You listed {items.Count} items");
    }
}