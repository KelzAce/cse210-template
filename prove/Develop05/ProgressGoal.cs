using EternalQuest;

namespace EternalQuest
{
    class ProgressGoal : Goal
    {
        private int targetValue;
        private int currentValue;

        public ProgressGoal(string name, int points, int targetValue) : base(name, points)
        {
            this.targetValue = targetValue;
            this.currentValue = 0;
        }

        public override void RecordEvent()
        {
            currentValue += Points;
            Console.WriteLine($"Progress on goal '{Name}'! Current progress: {currentValue}/{targetValue}");
        }

        public override bool IsCompleted() => currentValue >= targetValue;

        public override string GetStatus() => IsCompleted() ? "[X] " + Name: $"[ ] {Name} (Progress {currentValue}/{targetValue})";
    }
}