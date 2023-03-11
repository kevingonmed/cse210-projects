class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Exercise", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void Run()
    {
        Console.WriteLine("Breathe in...");
        Pause(Duration / 2);
        Console.WriteLine("Breathe out...");
        Pause(Duration / 2);
    }
}