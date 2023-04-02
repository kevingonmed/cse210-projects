using System;
class Program {
    static void Main(string[] args) {
        Address address1 = new Address("123 Main St.", "Anytown", "CA", "12345");
        Address address2 = new Address("456 Elm St.", "Sometown", "NY", "67890");
        Address address3 = new Address("789 Oak St.", "Othertown", "TX", "23456");

        Lecture lecture = new Lecture("Introduction to Programming", "Learn the basics of programming in C#", new DateTime(2023, 4, 15), "10:00 AM", address1, "John Smith", 50);
        Reception reception = new Reception("Networking Mixer", "Come mingle with other professionals in your industry", new DateTime(2023, 4, 20), "6:00 PM", address2, "rsvp@company.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Spring Festival", "Celebrate the season with food, music, and games", new DateTime (2023, 4, 30), "1:00 PM", address3, "Sunny");
         Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine(outdoorGathering.GetShortDescription());
}
}