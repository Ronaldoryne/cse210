using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

public class QuestManager
{
    private List<Goal> _goals;
    private int _score;

    public QuestManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            int points = _goals[goalIndex].RecordEvent();
            _score += points;
            Console.WriteLine($"Congratulations! You earned {points} points!");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nCurrent Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"\nYou have {_score} points.");
    }

    public void SaveToFile(string filename)
    {
        var data = new { Score = _score, Goals = _goals };
        string jsonString = JsonSerializer.Serialize(data);
        File.WriteAllText(filename, jsonString);
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            string jsonString = File.ReadAllText(filename);
            var data = JsonSerializer.Deserialize<dynamic>(jsonString);
            _score = data.Score;
            _goals = JsonSerializer.Deserialize<List<Goal>>(data.Goals.ToString());
        }
    }
}

