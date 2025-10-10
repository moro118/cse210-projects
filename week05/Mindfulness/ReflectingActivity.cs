public class ReflectingActivity : Activity
{
    List<string> _prompts = new List<string>();
    List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void Run() { 
        DateTime startime = DateTime.Now;
        DateTime futuretime = startime.AddSeconds(this._duration);
        DisplayPrompt();
        this.ShowCondown(6);
        Console.Clear();
      List<string> tempQuestions = new List<string>(_questions);

        while (DateTime.Now < futuretime)
        {
            if (tempQuestions.Count == 0)
            {
                tempQuestions = new List<string>(_questions);
            }

            Random random = new Random();
            int index = random.Next(tempQuestions.Count);
            string question = tempQuestions[index];
            Console.Write($"> {question} ");
            this.ShowSppiner(10);
            Console.WriteLine();
            tempQuestions.RemoveAt(index);
        }
    }

    string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(0,_prompts.Count-1)];
    }

    string GetRandomQuestion() {
         Random random = new Random();
        return _questions[random.Next(0, _questions.Count - 1)];
         }

    void DisplayPrompt() {
        Console.WriteLine(GetRandomPrompt());
     }

    void DisplayQuestion() {
        Console.WriteLine(GetRandomQuestion());
    }
}