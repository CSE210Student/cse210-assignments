using System.Runtime.CompilerServices;

public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {

    }

    public void DisplayAll()
    {

    }

    public void SaveToFile(string File)
    {
        Console.Write("What is the file name? ");
        string _fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach(Entry e in _entries)
            {
                outputFile.WriteLine(e._entryText);
            }
        }
    }

    public void LoadFile(string file)
    {
        Console.Write("What is the file name? ");
        string _fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(_fileName);
    }
}