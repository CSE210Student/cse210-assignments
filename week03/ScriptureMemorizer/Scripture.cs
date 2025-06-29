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
        int _hideAmount = randomGenerator.Next(1, 4);

        
    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }
}