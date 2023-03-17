public abstract class Goal
{
    public string name;
    protected int value;
    protected bool completed;
    public string Name {get{return name;} }

    public Goal(string name, int value)
    {
        this.name = name;
        this.value = value;
        this.completed = false;
    }

    // Abstract method to record progress toward the goal
    public abstract void RecordEvent();

    // Check if the goal has been completed
    public bool IsCompleted()
    {
        return completed;
    }

    // Get the point value of the goal
    public int GetValue()
    {
        return value;
    }

    // Get a string representation of the goal's status
    public virtual string GetStatus()
    {
        if (completed)
        {
            return "[X] " + name;
        }
        else
        {
            return "[ ] " + name;
        }
    }
}