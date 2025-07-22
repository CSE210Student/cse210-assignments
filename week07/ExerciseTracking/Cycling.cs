using System.Diagnostics;

public class Cycling : Activity
{
    public Cycling(int activityLength, double distance) : base(activityLength)
    {
        _distance = distance;
        _activityLength = activityLength;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _activityLength * 60;
    }

    public override double GetPace()
    {
        return _activityLength / _distance;
    }
}