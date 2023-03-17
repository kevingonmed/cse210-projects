using System;
using System.Collections.Generic;

class Program
{
    private static List<Goal> goals = new List<Goal>();
    private static int score = 0;

    // Display the list of goals and their status
    private static void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal.GetStatus());
        }
        Console.WriteLine();
    }

    // Record an event for a goal and update the score
    private static void RecordEventForGoal(Goal goal)
    {
        goal.RecordEvent();
        score += goal.GetValue();
        Console.WriteLine("Event recorded for " + goal.name + ".");
        Console.WriteLine("Score is now " + score + ".");
        Console.WriteLine();
    }

    // Main method
    static void Main(string[] args)
    {
        // Create some goals
        goals.Add(new SimpleGoal("Run a marathon", 1000));
        goals.Add(new EternalGoal("Read scriptures",100));
        goals.Add(new ChecklistGoal("Attend the temple", 50, 10));
            // Display initial goals and score
    DisplayGoals();
    Console.WriteLine("Score is " + score + ".");
    Console.WriteLine();

    // Loop to allow user to interact with the program
    bool exit = false;
    while (!exit)
    {
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Record an event");
        Console.WriteLine("2. Add a new goal");
        Console.WriteLine("3. Quit");
        Console.WriteLine();

        // Get user input
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        // Process user input
        switch (input)
        {
            case "1":
                Console.WriteLine("Which goal would you like to record an event for?");
                DisplayGoals();
                Console.Write("Enter the number of the goal: ");
                int goalIndex = Int32.Parse(Console.ReadLine()) - 1;
                RecordEventForGoal(goals[goalIndex]);
                break;

            case "2":
                Console.WriteLine("What type of goal would you like to add?");
                Console.WriteLine("1. Simple goal");
                Console.WriteLine("2. Eternal goal");
                Console.WriteLine("3. Checklist goal");
                Console.WriteLine();

                Console.Write("Enter a number: ");
                string goalTypeInput = Console.ReadLine();

                Console.Write("Enter the name of the goal: ");
                string goalNameInput = Console.ReadLine();

                Console.Write("Enter the point value of the goal: ");
                int goalValueInput = Int32.Parse(Console.ReadLine());

                switch (goalTypeInput)
                {
                    case "1":
                        goals.Add(new SimpleGoal(goalNameInput, goalValueInput));
                        break;

                    case "2":
                        goals.Add(new EternalGoal(goalNameInput, goalValueInput));
                        break;

                    case "3":
                        Console.Write("Enter the target count for the goal: ");
                        int goalTargetCountInput = Int32.Parse(Console.ReadLine());
                        goals.Add(new ChecklistGoal(goalNameInput, goalValueInput, goalTargetCountInput));
                        break;

                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }

                Console.WriteLine("Goal added.");
                Console.WriteLine();
                break;

            case "3":
                exit = true;
                break;

            default:
                Console.WriteLine("Invalid input.");
                Console.WriteLine();
                break;
        }
    }

    // Save goals and score to file (not implemented)
    Console.WriteLine("Saving goals and score to file...");
}
}    