namespace EternalQuest
{
    class NegativeGoal : Goal
    {
        public NegativeGoal(string name, int points) : base(name, points) {}

        public override void RecordEvent()
        {
            Points = -Points;
            Console.WriteLine($"Goal '{Name}' recorded! You lost {Math.Abs(Points)} points");
        }

        public override bool IsCompleted() => false;

        public override string GetStatus() => "[N] " + Name;
    }
}