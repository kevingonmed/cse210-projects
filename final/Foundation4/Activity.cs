public abstract class Activity
{
    private DateTime date;
    protected int length;

    public Activity(DateTime date, int length)
    {
        this.date = date;
        this.length = length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        string activityType = GetType().Name;
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();
        string unit = (activityType == "Swimming") ? "km" : "miles";

        string summary = $"{date:dd MMM yyyy} {activityType} ({length} min) - ";
        summary += $"Distance: {distance:F1} {unit}, Speed: {speed:F1} mph, Pace: {pace:F1} min per {unit}";

        return summary;
    }
}