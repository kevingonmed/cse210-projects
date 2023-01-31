public class PromptGenerator
{   
    

    public string _currentDate;

    public int randomNum;

    public List<string> _questionPrompts = new List<string>();
    public void DisplayPrompt() 
    {
        Console.WriteLine(_questionPrompts[randomNum]);
    }

}