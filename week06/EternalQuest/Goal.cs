public abstract class Goal
{
    string _shortname;
    string _description;
    string _points;

    public Goal(string name, string description, string points)
    {
        _shortname = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public string GetName()
    {
        return _shortname;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetPoints( string points)
    {
        _points = points;
    }
    public string GetPoints()
    {
        return _points;
    }
    public virtual string GetDetailsString()
    { 
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortname} ({_description})";
    }
    public abstract string GetStringRepresentation();
 
    
}