using System.Globalization;

public class ListingActivity : Activity
{
    int _count;
    List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {

        Console.WriteLine("List as many responses you can to the following prompt");
        GetRamdomPrompt();
        Console.Write("you may begin in: ");
        ShowCondown(5);
        Console.WriteLine("\n");
        List<string> userL=GetListFromUser();
        Console.WriteLine($"you listed {userL.Count} items!"); 
     }

    void GetRamdomPrompt()
    {
        Random random = new Random();
        Console.WriteLine(_prompts[random.Next(0,_prompts.Count-1)]);
    }
    List<string> GetListFromUser()
    {
        DateTime startime = DateTime.Now;
        DateTime futuretime = startime.AddSeconds(this._duration);
        List<string> userResponse = new List<string>();
        while (DateTime.Now < futuretime)
        {
            userResponse.Add(Console.ReadLine());
        }
        return userResponse;
    }
}