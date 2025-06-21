using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        Entry anEntry = new Entry();
        
        Console.WriteLine("What is your current mood?");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Angry");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Sad");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Happy");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Neutral");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(">");
        anEntry._mood = Console.ReadLine();

        PromptGenerator prompts = new PromptGenerator();
        anEntry._promptText = prompts.GetRandomPrompt();
        Console.WriteLine($"Prompt: {anEntry._promptText}");

        DateTime currentTime = DateTime.Now;
        anEntry._date = currentTime.ToShortDateString();
        Console.WriteLine($"Date: {anEntry._date}");

        Console.Write(">");
        anEntry._entryText = Console.ReadLine();

        _entries.Add(anEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        Console.WriteLine("Saving File...");
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}-{e._promptText}-{e._mood}-{e._entryText}");
            }
        }
    }

    public void LoadFile(string file)
    {
        Entry anEntry = new Entry();
        Console.WriteLine("Loading File...");
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("-");

            string date = parts[0];
            anEntry._date = date;
            string prompt = parts[1];
            anEntry._promptText = prompt;
            string mood = parts[2];
            anEntry._mood = mood;
            string entryText = parts[3];
            anEntry._entryText = entryText;

            _entries.Add(anEntry);
        }
    }
}