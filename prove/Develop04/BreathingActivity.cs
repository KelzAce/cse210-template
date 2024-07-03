class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base(duration) {}

    protected override void PerformActivity()
    {
       Console.WriteLine("Breath Deeply...");
       Thread.Sleep(Duration * 1000);
    }
}