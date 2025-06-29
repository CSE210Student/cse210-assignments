public class Word
{
    private string _text;
    private bool _isHidden;
    private Word word;

    public Word(string text)
    {
        _text = text;
    }

    public Word(Word word)
    {
        this.word = word;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        if (_isHidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetDisplayText()
    {
        string _hidden = _text;
;
        if (_isHidden == true)
        {
            _hidden = new string('_', _text.Length);

            return _hidden;
        }
        
        return _hidden;
    }
}