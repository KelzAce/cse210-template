using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    class QuestManager
    {
        private List<Goal> goals;
        private int totalScore;

        public QuestManager()
        {
            goals = new List<Goal>();
            totalScore = 0;
        }

        public void AddGoal(Goal goal)
        {
            goals.Add(goal);
        }

        public void RecordEvent(string goalName)
        {
            Goal goal = goals.Find(g => g.Name == goalName);
            if (goal != null)
            {
                goal.RecordEvent();
                totalScore += goal.Points;
                if (goal is ChecklistGoal checklistGoal && checklistGoal.IsCompleted())
                {
                    totalScore += checklistGoal.GetBonusPoints();
                }
            }
            else
            {
                Console.WriteLine($"Goal '{goalName}' not found. ");
            }
        }

        public void ShowGoals()
        {
            foreach (var goal in goals)
            {
                Console.WriteLine(goal.GetStatus());
            }
        }

        public void ShowScore()
        {
            Console.WriteLine($"TotalScore: {totalScore}");
        }

        public void SaveProgress(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(totalScore);
                foreach (var goal in goals)
                {
                    writer.WriteLine($"{goal.GetType().Name}|{goal.Name}|{goal.Points}|{goal.GetStatus()}");
                }
            }
        }

        public void LoadProgress(string filename)
        {
            if (File.Exists(filename))
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    totalScore = int.Parse(reader.ReadLine());
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        string goalType = parts[0];
                        string name = parts[1];
                        int points = int.Parse(parts[2]);

                        switch (goalType)
                        {
                            case "SimpleGoal":
                                bool completed = parts[3] == "[X]";
                                SimpleGoal simpleGoal = new SimpleGoal(name, points);
                                if (completed)
                                {
                                    simpleGoal.RecordEvent();
                                }
                                goals.Add(simpleGoal);
                                break;
                            case "EternalGoal":
                                goals.Add(new EternalGoal(name, points));
                                break;
                            case "ChecklistGoal":
                                int currentCount = int.Parse(parts[3].Split('/')[0].Split(' ')[2]);
                                int targetCount = int.Parse(parts[3].Split('/')[1].Split(' ')[0]);
                                int bonusPoints = int.Parse(parts[4]);

                                ChecklistGoal checklistGoal = new ChecklistGoal(name, points, targetCount, bonusPoints);
                                for (int i = 0; i < currentCount; i++)
                                {
                                    checklistGoal.RecordEvent();
                                }
                                goals.Add(checklistGoal);
                                break;
                        }
                    }
                }
            }
        }
    }
}