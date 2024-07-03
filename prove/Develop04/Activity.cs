abstract class Activity
{
    protected int Duration{get; private set; }
    public Activity(int duration)
    {
        Duration = duration;
    }

    public void Start()
    {
        ShowStartingMessage();
        PerformActivity();
        ShowEndingMessage();
    }

    protected virtual void ShowStartingMessage()
    {
        Console.WriteLine($"{this.GetType().Name} Activity");
        Console.WriteLine($"Duration: {Duration}");
        Console.WriteLine($"Prepare to Begin ");
        ShowAnimation();

    }

     protected virtual void ShowEndingMessage()
    {
        Console.WriteLine($"Well Done ");
        Console.WriteLine($"You have completed the {this.GetType().Name} Activity for {Duration} seconds ");
    }

    protected abstract void PerformActivity();

    protected void ShowAnimation()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }

        Console.WriteLine();
    }
}
