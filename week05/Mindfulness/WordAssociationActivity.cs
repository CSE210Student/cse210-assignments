public class WordAssociationActivity : Activity
{
    private List<string> _words =
    [
        "Cloud",
        "Rain",
        "Moon",
        "Cold",
        "Lonely",
        "Bird",
        "Happy",
        "Time",
        "Glass",
        "Brave",
        "Dream",
        "Success",
        "Smile",
        "Focus",
        "Live",
        "Laugh",
        "Love",
        "Day",
        "Night",
        "Star",
        "Clock",
        "Wonder",
        "King",
        "Music",
        "Hero",
        "Villain",
        "Lost",
        "Journey",
        "Quest",
        "Never",
        "Honey",
        "Awake",
        "Sleep",
        "Flower",
        "Speak",
        "Puppet"
    ];

    public WordAssociationActivity()
    {
        _name = "Word Association Activity";
        _description = "This activity will help you take a moment to see how you associate different words with others. You will be given a random word, and are to write the first word that comes to mind.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            GetRandomWord();
            Console.ReadLine();
        }

        Console.Write("\nPlease take a moment to review your answers. Press ENTER when you are finished.");
        Console.ReadLine();

        DisplayEndingMessage();
    }

    public void GetRandomWord()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_words.Count);
        string _word = _words[index];
        Console.Write($"{_word} : ");
    }
}