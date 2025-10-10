public class Activity
{
    string _name;
    string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;  
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Wellcome to the {_name}");
        Console.WriteLine(_description);
        Console.WriteLine("Please Enter The duration Of The Activity in Seconds");
        this._duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Getting Ready...");
        this.ShowSppiner(5);
        Console.Clear();
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done you have completed another {_duration} seconds of the {_name}");
        this.ShowSppiner(5);
        Console.Clear();
    }
    public void ShowSppiner(int seconds)
    {
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        
        DateTime starttime = DateTime.Now;
        DateTime endtime = starttime.AddSeconds(seconds);
        while (DateTime.Now < endtime)
        {
            foreach (string s in spinner)
            {
                Console.Write("..."+s);
                Console.Write("\b\b\b\b");
                Thread.Sleep(1000);
            }
           
        }
    }

    public void ShowCondown(int sec)
    { 
        DateTime starttime = DateTime.Now;
        DateTime endtime = starttime.AddSeconds(sec);

        while (DateTime.Now < endtime)
        {
            Console.Write("..."+sec);
            Console.Write("\b\b\b\b");
            Thread.Sleep(1000);
            sec--;
        }
    }
}