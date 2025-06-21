using System;

class Program
{
    static void Main(string[] args)
    {

        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        anEntry.Display();

        Console.WriteLine("Welcome to the Journal Program");
        Console.WriteLine("Select a menu option from the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        string userChoice = Console.ReadLine();
        int choice = int.Parse(userChoice);

        if (choice == 1)
        {
            theJournal.AddEntry(anEntry);
        }
    }
}