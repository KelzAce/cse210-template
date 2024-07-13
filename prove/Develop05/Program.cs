using System;

namespace EternalQuest
{
    class Program
{
    static void Main(string[] args)
    {
        QuestManager quest = new QuestManager();

        //Add some initial goals
        quest.AddGoal(new SimpleGoal("Wake up at 6am", 1000));
        quest.AddGoal(new EternalGoal("Read Scriptures", 1000));
        quest.AddGoal(new ChecklistGoal("Attend Church Service", 50, 10, 500));

        //display goals
        quest.ShowGoals();

        //Record events
        quest.ShowGoals();
        quest.ShowScore();

        //Save and Load Progress
        string filename = "progress.txt";
        quest.SaveProgress(filename);
        quest.LoadProgress(filename);

        //Display loaded goals and score
        quest.ShowGoals();
        quest.ShowScore();
    }
}
}
