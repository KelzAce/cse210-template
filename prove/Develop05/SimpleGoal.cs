namespace EternalQuest
{
    class SimpleGoal : Goal
    {
        private bool completed;

        public SimpleGoal(string name, int points) : base(name, points)
        {
            completed = false;
        }

        public override void RecordEvent()
        {
            if (!completed)
            {
                completed = true;
                Console.WriteLine($"Goal '{Name}' is already completed");
            }
        }

        public override bool IsCompleted() => completed;

        public override string GetStatus() => completed ? "[X]" : "[]" + Name;
    }
}