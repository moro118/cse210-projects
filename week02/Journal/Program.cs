using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Entry entry=null;
        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = "";
        while (choice != "5")
        {

            Console.WriteLine("PLease Choose one of the following options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.Write(prompt);
                string userReponse = Console.ReadLine();
                entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = userReponse;
                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
               journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter the filename to load from: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter the filename to save to: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
    
}