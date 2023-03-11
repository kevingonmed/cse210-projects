class ListingActivity : Activity
{
    private readonly string[] prompts = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Exercise", "This activity will help you reflect on the good things in your life by listing them out. This can help shift your focus to the positive and increase feelings of gratitude.")
{
}
public override void Run()
{
    Console.WriteLine("Think about the following prompt and list out your answers:");
    string prompt = prompts[new Random().Next(prompts.Length)];
    Console.WriteLine(prompt);
    Pause(3);

    Console.WriteLine("Start listing...");
    Pause(Duration);
}
}