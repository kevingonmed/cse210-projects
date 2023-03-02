
class ScriptureGame
{
    private Scripture _scripture;
    private List<int> _hiddenIndices;

    public ScriptureGame(Scripture scripture)
    {
        _scripture = scripture;
        _hiddenIndices = new List<int>();
    }

    public void Start()
    {
        // Loop until all words have been hidden
        while (_hiddenIndices.Count < _scripture.Text.Split(' ').Length)
        {
            // Clear the console screen
            Console.Clear();

            // Print the scripture with hidden words
            string hiddenText = _scripture.GetHiddenText(_hiddenIndices);
            Console.WriteLine(_scripture.Reference + ": " + hiddenText);

            // Prompt the user to press enter or type quit
            Console.WriteLine("\n\nPress ENTER to continue or type 'quit' to exit.");
            string input = Console.ReadLine().ToLower();

            // Check if the user wants to quit
            if (input == "quit")
            {
                break;
            }

            // Randomly hide a few more words
            Random random = new Random();
            int numToHide = random.Next(1, 4); // hide between 1 and 3 words
            for (int i = 0; i < numToHide; i++)
            {
                int index;
                do
                {
                    index = random.Next(_scripture.Text.Split(' ').Length);
                } while (_hiddenIndices.Contains(index));
                _hiddenIndices.Add(index);
            }
        }

        // Clear the console screen one last time
        Console.Clear();

        // Print the complete scripture with reference
        Console.WriteLine(_scripture.Reference + ": " + _scripture.Text);

        // Wait for user to press enter to exit
        Console.WriteLine("\nPress ENTER to exit.");
        Console.ReadLine();
    }
}