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
        // int _hideAmount = randomGenerator.Next(1, 4);

        for (int _hideAmount = randomGenerator.Next(1, 4); _hideAmount > 0; _hideAmount--)
        {
            //word to hide index
            int _wordToHide = randomGenerator.Next(0, _words.Count());

            if (_words[_wordToHide].IsHidden() == false)
            {
                _words[_wordToHide].Hide();
            }
        }
    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}