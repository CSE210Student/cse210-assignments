using System.Runtime.CompilerServices;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted == _target)
        {
            IsComplete();
        }
        else
        {
            _amountCompleted++;
        }
    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetDetailsString()
    {
        char _completeMark = IsComplete() ? 'x' : ' ';
        return $"[{_completeMark}] {GetName()} - ({GetDescription()}) (Completed: {_amountCompleted}/{_target})";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal | {GetName()} | {GetDescription()} | {GetPoints()} | {_bonus} | {_target} | {_amountCompleted}";
    }
}