using System.Diagnostics;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(int activityLength, int laps) : base(activityLength)
    {
        _laps = laps;
        _activityLength = activityLength;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / _activityLength * 60;
    }

    public override double GetPace()
    {
        return _activityLength / GetDistance();
    }
}