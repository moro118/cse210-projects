public class ChecklistGoal : Goal
{
    int _amountCompleted;
    int _target;

    int _bonus;

    public ChecklistGoal(string name, string description, string pointsPerCompletion, int target, int bonus) : base(name, description, pointsPerCompletion)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

     public ChecklistGoal(string name, string description, string points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }
    public override int RecordEvent()
    {
         if (_amountCompleted < _target)
        {
            _amountCompleted++;
            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Congratulations! You have earned {this.GetPoints()} points and a bonus of {this._bonus} points!");
                 return int.Parse(GetPoints()) + _bonus;
            }
            else
            {
                Console.WriteLine($"Congratulations! You have earned {this.GetPoints()} points!");
                return int.Parse(GetPoints());
            }
        }
        Console.WriteLine("You have already completed this goal for the target number of times.");
        return 0;

    }

    public override bool IsComplete() { 
         return _amountCompleted >= _target;
     }
    public override string GetStringRepresentation() {
       return $"ChecklistGoal:{this.GetName()},{this.GetDescription()},{this.GetPoints()},{_bonus},{_target},{_amountCompleted}";
    
     }
    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {this.GetName()} ({this.GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
    }
}