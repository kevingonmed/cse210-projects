abstract class Activity
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int Duration { get; private set; }

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void Start()
    {
        Console.WriteLine($"{Name}: {Description}");
        Duration = PromptDuration();
        Console.WriteLine("Get ready to begin in 3 seconds...");
        Thread.Sleep(3000);
    }

    private int PromptDuration()
    {
        while (true)
        {
            Console.Write("Enter duration of activity in seconds: ");
            string durationStr = Console.ReadLine();
            if (int.TryParse(durationStr, out int duration))
            {
                return duration;
            }
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }

    protected void Pause(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}...");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void Run();
}