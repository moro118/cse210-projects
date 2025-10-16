using System;
// Exceeded requirements: Added XP/Leveling system and a 'First Goal Completed' badge with bonus points and persistence."
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Eternal Quest!");
        Console.Write("Enter your character's name: ");
        string playerName = Console.ReadLine();
        GoalManager player = new GoalManager();
        Console.WriteLine($"Hello, {playerName}! Let's start your adventure.");
        player.Start();
        
    }
}