namespace EternalQuest
{
    class EternalGoal : Goal
    {
        public EternalGoal(string name, int points) : base(name, points) {}

        public override void RecordEvent()
        {
            Console.WriteLine($"Goal '{Name}' recorded? You earned {Points} points. ");
        }

        public override bool IsCompleted() => false;

        public override string GetStatus() => "[] " + Name;
    }
}