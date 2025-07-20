public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal()
    {

    }

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        char _completeMark = IsComplete() ? 'x' : ' ';
        return $"[{_completeMark}] {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();

    public string GetName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }
}