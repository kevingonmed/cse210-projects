using System;



class Program
{
    static void Main(string[] args)
    {
        Activity[] activities = new Activity[]
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0),
            new Running(new DateTime(2022, 11, 3), 30, 4.8),
            new StationaryBicycle(new DateTime(2022, 11, 3), 30, 12.0),
            new Swimming(new DateTime(2022, 11, 3), 30, 20),
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
