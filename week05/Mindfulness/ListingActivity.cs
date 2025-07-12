using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts =
    [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    ];
    private List<string> _userResponses = new List<string>();

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity is designed to help you reflect on good things in your life by having you list as many of them as you can regarding a specific area.";
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.Write("\n\nHow long, in seconds, would you like the activity to last? > ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("\nBegin in... ");
        ShowCountDown(3);
        Console.WriteLine("\n");

        GetListFromUser();

        _count = _userResponses.Count();

        Console.WriteLine($"\nYou listed {_count} items!");

        DisplayEndingMessage();

    }

    public void GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count);
        string _prompt = _prompts[index];
        Console.WriteLine(_prompt);
    }

    public List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        string userAnswer = "";

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            userAnswer = Console.ReadLine();
            _userResponses.Add(userAnswer);
        }

        return _userResponses;
    }
}