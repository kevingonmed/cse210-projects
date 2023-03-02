using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new scripture
        Scripture scripture = new Scripture("Proverbs 3 5-6", "5: Trust in the Lord with all thine heart; and lean not unto thine own understanding. 6: In all thy ways aacknowledge him, and he shall direct thy paths.");

        // Create a new game with the scripture
        ScriptureGame game = new ScriptureGame(scripture);

        // Start the game
        game.Start();
    }
}
