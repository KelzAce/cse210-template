namespace EternalQuest
{
    class ChecklistGoal : Goal
    {
        private int targetCount ;
        private int currentCount ;
        private int bonusPoints;

        public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points)
        {
            this.targetCount = targetCount;
            this.bonusPoints = bonusPoints;
            currentCount = 0;
        }

        public override void RecordEvent()
        {
            if (currentCount < targetCount)
            {
                currentCount++;
                Console.WriteLine($"Progress on goal '{Name}'! You earned {Points} points.  Completed {currentCount}/{targetCount} times.");
                if (currentCount == targetCount)
                {
                    Console.WriteLine($"Goal '{Name}' completed! You earned an additional {bonusPoints} bonus points.");
                }
            }
            else
            {
                Console.WriteLine($"Goal '{Name}' is already completed. ");
            }
        }

        public int GetBonusPoints()
        {
            return currentCount >= targetCount ? bonusPoints : 0;
        }
        public override bool IsCompleted() => currentCount >= targetCount;

        public override string GetStatus() => currentCount >= targetCount ? "[X] " + Name : $"[] {Name} (Completed {currentCount}/{targetCount} times)";
    }
}