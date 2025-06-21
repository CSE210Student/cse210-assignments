using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        PromptGenerator prompts = new PromptGenerator();
        Entry anEntry = new Entry();
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
                outputFile.WriteLine($"{e._date}-{e._promptText}-{e._entryText}");
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
            string entryText = parts[2];
            anEntry._entryText = entryText;

            _entries.Add(anEntry);
        }
    }
}