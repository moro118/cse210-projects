/*
 * CREATIVITY / EXCEEDING REQUIREMENTS:
 * To exceed the requirements for the assignment, I have implemented a feature
 * in the Reflecting Activity to ensure that questions are not repeated during a single session.
 * The program creates a temporary copy of the question list and removes each question
 * after it has been displayed, guaranteeing the user sees a variety of prompts
 * until the list is exhausted.
*/

using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        string option = "";
        while (option != "4")
        {
            Console.WriteLine("Please Chose An Option");
            Console.WriteLine("1.-BreathingActivity");
            Console.WriteLine("2.-ReflectingActivity");
            Console.WriteLine("3.-ListingActivity");
            Console.WriteLine("4.-quit");
            option = Console.ReadLine();
            int duration = 0;
            switch (option)
            {
                case "1":    
                    BreathingActivity mybreathingActivity = new BreathingActivity("Breathing Activity", "Activity That Helpyou to Breath Well", duration);
                    mybreathingActivity.DisplayStartingMessage();
                    mybreathingActivity.Run();
                    mybreathingActivity.DisplayEndingMessage();
                    break;
                case "2":
                    ReflectingActivity myReflectingActivity = new ReflectingActivity("Reflecting Activity", "Activity that helps to Reflect",duration);
                    myReflectingActivity.DisplayStartingMessage();
                    myReflectingActivity.Run();
                    myReflectingActivity.DisplayEndingMessage();
                    break;
                case "3":
                    ListingActivity myListingActivity = new ListingActivity("Listing Activity","Activity that helps you to think posutive",duration);
                    myListingActivity.DisplayStartingMessage();
                    myListingActivity.Run();
                    myListingActivity.DisplayEndingMessage();
                    break;
                case "4":
                    Console.WriteLine("Quiting Program");
                    break;
                default:
                    Console.WriteLine("UnKnown Option");
                    break;
            }
            Console.Clear();
        }

    }
}