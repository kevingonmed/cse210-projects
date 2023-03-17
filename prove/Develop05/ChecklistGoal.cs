public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;

    public ChecklistGoal(string name, int value, int targetCount) : base(name, value)
    {
        this.targetCount = targetCount;
        this.currentCount = 0;
    }

    // Increment the count and award points, or mark the goal as completed and award a bonus
    public override void RecordEvent()
    {
        currentCount++;
        value += value;

        if (currentCount == targetCount)
        {
            value += 500;
            completed = true;
        }
    }

    // Get a string representation of the goal's status, including the current count
    public override string GetStatus()
    {
        if (completed)
        {
            return "[X] " + name + " (Completed)";
        }
        else
        {
            return "[ ] " + name + " (Completed " + currentCount + "/" + targetCount + " times)";
        }
    }
}