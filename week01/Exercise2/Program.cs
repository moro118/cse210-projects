using System;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);


        string letter = "";
        string sign = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int lastDigit = grade % 10;
        if (letter == "A")
        {
            if (lastDigit < 3)
            {
                sign = "-";
            }
            // No A+
        }
        else if (letter == "F")
        {
            // No F+ or F-
            sign = "";
        }
        else
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't give up! Better luck next time.");
        }
    }
}