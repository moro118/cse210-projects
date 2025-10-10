public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration): base(name,description,duration)
    { 
        
    }
    public void Run()
    {
        DateTime startime = DateTime.Now;
        DateTime futuretime = startime.AddSeconds(this._duration);
        while (DateTime.Now < futuretime)
        {
            Console.WriteLine("Breath in ");
            this.ShowCondown(6);
            Console.WriteLine("Now breathe out ");
            this.ShowCondown(6);
        }

    }
    
}