using System;

public class main
{

    static void Main(string[] args)
    {
        

        //Journal _journalReference = new Journal();

        PromptGenerator _promptReference = new PromptGenerator();

        Random random = new Random();

        
        _promptReference._questionPrompts.Add("Who was the most interesting person I interacted with today?");
        _promptReference._questionPrompts.Add("What was the best part of my day?");
        _promptReference._questionPrompts.Add("Who are you more like, your mom or your dad?");
        _promptReference._questionPrompts.Add("What is your greatest joy");
        _promptReference._questionPrompts.Add("What is your greatest fear?");
        _promptReference._questionPrompts.Add("Why did you choose to study promming if it is so frustrating at times?");


        int randomNum = random.Next(0, _promptReference._questionPrompts.Count);
        _promptReference.randomNum = randomNum;

        //_journalReference._date = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        
        bool _continueJournal = true;

        while (_continueJournal == true) {

            Console.WriteLine ("Please select one of the following choices");
            Console.WriteLine ("1) Write");
            Console.WriteLine ("2) Display");
            Console.WriteLine ("3) Load");
            Console.WriteLine ("4) Save");
            Console.WriteLine ("5) Quit");
            Console.WriteLine("What would you like to do? ");
            int _userInput = int.Parse(Console.ReadLine());

            switch(_userInput) 
            {
            case 1:
                // Write
                _promptReference.DisplayPrompt();

                Console.Write(">");

                
                
                break;
            case 2:
                

                _promptReference.DisplayPrompt();


                
                break;
            case 3:
                // Save
                break;
            case 4:
                // Load
                break;
            case 5:
                // Quit
                    Console.WriteLine("See you soon!");
                    _continueJournal = false;
                break;
            }

        }

    }

}

