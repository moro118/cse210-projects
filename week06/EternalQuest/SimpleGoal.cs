public class SimpleGoal : Goal
{
    bool _isComplete = false;
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }
    public SimpleGoal(string name, string description, string points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations! You have earned {this.GetPoints()} points!");
            return int.Parse(GetPoints());
        }
        else
        {
            Console.WriteLine("This goal has already been completed.");
            return 0;
        }
       
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{this.GetName()},{this.GetDescription()},{this.GetPoints()},{_isComplete}";
    }
    
}