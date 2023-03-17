public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value) : base(name, value)
    {
    }

    // Mark the goal as completed
    public override void RecordEvent()
    {
        completed = true;
    }
}

// Define an eternal goal that can never be completed
public class EternalGoal : Goal
{
    public EternalGoal(string name, int value) : base(name, value)
    {
    }

    // Mark progress toward the goal (always adds points)
    public override void RecordEvent()
    {
        value += value;
    }
}