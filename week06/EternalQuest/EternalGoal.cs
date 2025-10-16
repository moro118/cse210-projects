public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, string pointsPerCompletion) : base(name, description, pointsPerCompletion)
    {

    }

    public  override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {this.GetPoints()} points!");
       return int.Parse(GetPoints());
    }
    public override bool IsComplete()
    { 
        return false;
    }
    public override string GetStringRepresentation()
    {
          return $"EternalGoal:{this.GetName()},{this.GetDescription()},{this.GetPoints()}";
    }
}