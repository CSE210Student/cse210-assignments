public class Entry
{
    public string _mood;
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"{_date}---{_promptText}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine($"{_entryText}");
    }
}