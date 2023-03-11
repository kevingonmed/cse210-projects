class Program
    {
    static void Main(string[] args)
{
Activity[] activities = new Activity[]
{
new BreathingActivity(),
new ReflectionActivity(),
new ListingActivity()
};
    Console.WriteLine("Welcome to the Self-Care Activity App!");
    Console.WriteLine("You will be prompted to choose from the following activities:");
    for (int i = 0; i < activities.Length; i++)
    {
        Console.WriteLine($"{i+1}. {activities[i].Name}");
    }

    while (true)
    {
        Console.Write("Enter the number of the activity you would like to do: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int choice) && choice > 0 && choice <= activities.Length)
        {
            Activity chosenActivity = activities[choice - 1];
            Console.WriteLine($"You have chosen {chosenActivity.Name}. Let's begin!");
            chosenActivity.Start();
            chosenActivity.Run();
            Console.WriteLine($"You have completed {chosenActivity.Name}. Good job!");
            break;
        }
        Console.WriteLine("Invalid input. Please enter a number corresponding to one of the activities.");
    }

    Console.WriteLine("Press any key to exit.");
    Console.ReadKey();
 }
}