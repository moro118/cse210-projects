using System;

class Program
{
    static void Main(string[] args)
    {
       
  
        List<Activity> activities = new List<Activity>();

     
        activities.Add(new Running(new DateTime(2025, 11, 03), 30, 3.0));
        activities.Add(new Cycling(new DateTime(2025, 11, 04), 45, 15.0));
        activities.Add(new Swimming(new DateTime(2025, 11, 05), 60, 40));

        Console.WriteLine("Exercise Tracking Summary:");
        Console.WriteLine("--------------------------");

   
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
    
}