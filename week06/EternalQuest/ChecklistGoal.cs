using System.Runtime.CompilerServices;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int bonus, int target) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, int points, int bonus, int target, int amountCompleted) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        int _points = GetPoints();
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            IsComplete();
            _points += _bonus;
        }

        return _points;
    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetDetailsString()
    {
        char _completeMark = IsComplete() ? ' ' : 'x';
        return $"[{_completeMark}] {GetName()} - ({GetDescription()}) (Completed: {_amountCompleted}/{_target})";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_bonus}|{_target}|{_amountCompleted}";
    }
}