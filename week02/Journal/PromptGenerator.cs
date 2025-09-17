public class PromptGenerator
{
    List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        _prompts.Add("What was the best part of your day?");
        _prompts.Add("What was the most challenging part of your day?");
        _prompts.Add("What are you grateful for today?");
        _prompts.Add("What is something new you learned today?");
        _prompts.Add("Describe a moment that made you smile today.");
        Random random = new Random();
        int index = random.Next(_prompts.Count);    
        return _prompts[index];
    }

}