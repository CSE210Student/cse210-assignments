public abstract class Activity
{
    private DateTime _date = DateTime.Now;
    private int _length;

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public string GetSumarry()
    {
        return "";
    }
}