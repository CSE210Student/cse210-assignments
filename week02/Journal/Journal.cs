using System.Runtime.CompilerServices;

public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {

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
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach(Entry e in _entries)
            {
                outputFile.WriteLine(e._entryText);
            }
        }
    }

    public void LoadFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
    }
}