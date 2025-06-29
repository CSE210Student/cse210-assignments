using System.Globalization;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        string[] _split = text.Split(" ");

        foreach (string k in _split)
        {
            Word _wordPlace = new Word(k);
            _words.Add(_wordPlace);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random randomGenerator = new Random();

        for (int _numberToHide = numberToHide; _numberToHide > 0; _numberToHide--)
        {
            int index = randomGenerator.Next(0, _words.Count);
            Word word = new Word(_words[index]);
            
            if (_words[index].IsHidden() == false)
            {
                _words[index].Hide();
            }
            else
            {
                _numberToHide += 1;
            }
        }
    }

    public string GetDisplayText()
    {
        string _displayText = $"{_reference.GetDisplayText()} ";

        foreach (Word word in _words)
        {
            _displayText += $"{word.GetDisplayText()} ";
        }

        return _displayText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}