public class GoalManager
{
    List<Goal> _goalList;
    int _score;
    bool _firstGoalBadgeEarned;

    public GoalManager()
    {
        _goalList = new List<Goal>();
        _score = 0;
        _firstGoalBadgeEarned = false;
    }

    public void Start()
    {
        bool playing = true;
         DisplayPLayerInfo();
        while (playing)
        {
            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Create a New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    this.CreateGoal();
                    break;
                case "2":
                    this.ListGoalsDetails();
                    break;
                case "3":
                    this.SaveGoals();
                    break;
                case "4":
                    this.LoadGoals();
                    break;
                case "5":
                    this.RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Thank you for playing Eternal Quest! Goodbye.");
                    playing = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
            
    }
    public void DisplayPLayerInfo()
    {
        int level = GetLevelFromScore(_score);
        int xp = _score % 100;
        string badgeStatus = _firstGoalBadgeEarned ? "Yes" : "No";
        Console.WriteLine($"You have {_score} points. Level {level} (XP: {xp}/100) - Badge: First Goal Completed: {badgeStatus}");
    }

    // Helper to compute level from score
    private int GetLevelFromScore(int score)
    {
        return (score / 100) + 1;
    }

    public void ListGoalsNames()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goalList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goalList[i].GetName()}");
        }
    }
    public void ListGoalsDetails()
    {
        for (int i = 0; i < _goalList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goalList[i].GetDetailsString()}");
        }
        Console.ReadLine();
    }
    public void CreateGoal()
    {
        string goalType = "";
        do
        {
            DisplayPLayerInfo();
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine(" 1. Simple Goal");
            Console.WriteLine(" 2. Eternal Goal");
            Console.WriteLine(" 3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            goalType = Console.ReadLine();
             List<string> details= new List<string>();
            switch (goalType)
            {
                case "1":
                    Console.WriteLine("You have selected Simple Goal.");
                    details = RequestGoalDetail();
                    SimpleGoal simpleGoal = new SimpleGoal(details[0], details[1], details[2]);
                    _goalList.Add(simpleGoal);

                    break;
                case "2":
                    Console.WriteLine("You have selected Eternal Goal.");
                    details = RequestGoalDetail();
                    EternalGoal eternalGoal = new EternalGoal(details[0], details[1], details[2]);
                    _goalList.Add(eternalGoal);
                    break;
                case "3":
                    Console.WriteLine("You have selected Checklist Goal.");
                    details = RequestGoalDetail();
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());
                    ChecklistGoal checklistGoal = new ChecklistGoal(details[0], details[1], details[2], target, bonus);
                    _goalList.Add(checklistGoal);
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }

        } while (goalType != "1" && goalType != "2" && goalType != "3");



    }
    List<string>  RequestGoalDetail()
    {
        List<string> details = new List<string>();  
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string pointsPerCompletion = Console.ReadLine();  
        details.Add(name);
        details.Add(description);
        details.Add(pointsPerCompletion);
        return details;   
    }
    public void RecordEvent()
    {
        ListGoalsDetails();
        Console.Write("Which goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goalList.Count)
        {
            int previousLevel = GetLevelFromScore(_score);
            int pointsEarned = _goalList[goalIndex].RecordEvent();
            _score += pointsEarned;
            int newLevel = GetLevelFromScore(_score);
            if (pointsEarned > 0 && newLevel > previousLevel)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Level up! You reached level {newLevel}!\n");
                Console.ResetColor();
            }

            // Award first-goal badge and bonus points
            if (pointsEarned > 0 && !_firstGoalBadgeEarned)
            {
                _firstGoalBadgeEarned = true;
                int bonus = 50;
                _score += bonus;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Badge earned: First Goal Completed! Bonus {bonus} points awarded.");
                Console.ResetColor();
            }

            DisplayPLayerInfo();
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    public void LoadGoals()
    {
 Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        _goalList.Clear(); // Clear existing goals before loading

        string[] lines = System.IO.File.ReadAllLines(filename);

        string[] headerParts = lines[0].Split(',');
        _score = int.Parse(headerParts[0]);
        if (headerParts.Length > 1)
            _firstGoalBadgeEarned = headerParts[1] == "1";
        else
            _firstGoalBadgeEarned = false;

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string type = parts[0];
            string[] data = parts[1].Split(',');

            string name = data[0];
            string description = data[1];
            int points = int.Parse(data[2]);

            if (type == "SimpleGoal")
            {
                bool isComplete = bool.Parse(data[3]);
                _goalList.Add(new SimpleGoal(name, description, points.ToString(),isComplete) { });
            }
            else if (type == "EternalGoal")
            {
                _goalList.Add(new EternalGoal(name, description, points.ToString()));
            }
            else if (type == "ChecklistGoal")
            {
                int bonus = int.Parse(data[3]);
                int target = int.Parse(data[4]);
                int amountCompleted = int.Parse(data[5]);
                _goalList.Add(new ChecklistGoal(name, description, points.ToString(), target, bonus, amountCompleted));
            }
        }
        Console.WriteLine("Goals loaded successfully.");
       DisplayPLayerInfo();
    }
    public void SaveGoals()
    {
          Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
           
           
            outputFile.WriteLine($"{_score},{(_firstGoalBadgeEarned ? 1 : 0)}");
            foreach (Goal goal in _goalList)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }
}