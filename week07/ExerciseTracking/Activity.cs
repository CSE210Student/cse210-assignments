public abstract class Activity
{
    protected DateTime _date = DateTime.Now;
    protected int _activityLength;
    protected double _distance;

    public Activity(int activityLength)
    {
        _activityLength = activityLength;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public string GetSummary()
        {
            return $"{_date.ToShortDateString()} {GetType()} ({_activityLength} min)- Distance: {GetDistance()} Miles, Speed: {GetSpeed()} mph, Pace {GetPace()} min per mile";
        }
}