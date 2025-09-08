using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
       Console.WriteLine("Please ENter Your Last Name");
       string LastName = Console.ReadLine();
       Console.WriteLine($"Your name is {LastName}, {name} {LastName}");   
    }
}