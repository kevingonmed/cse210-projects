class Scripture
{
    public string Reference { get; set; }
    public string Text { get; set; }

    public Scripture(string reference, string text)
    {
        Reference = reference;
        Text = text;
    }

    public string GetHiddenText(List<int> hiddenIndices)
    {
        // Split the scripture text into individual words
        string[] words = Text.Split(' ');

        // Create a new string with hidden words
        string hiddenText = "";
        for (int i = 0; i < words.Length; i++)
        {
            if (hiddenIndices.Contains(i))
            {
                hiddenText += "___ ";
            }
            else
            {
                hiddenText += words[i] + " ";
            }
        }
        return hiddenText.Trim();
    }
}