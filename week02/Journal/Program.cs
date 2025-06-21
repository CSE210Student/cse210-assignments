using System;
using System.Collections.Generic;
using System.IO;

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

        else if (choice == 2)
        {
            theJournal.DisplayAll();
        }

        else if (choice == 3)
        {
            Console.Write("What is the file name? ");
            string file = Console.ReadLine();
            theJournal.LoadFile(file);
        }

        else if (choice == 4)
        {
            Console.Write("What is the file name? ");
            string file = Console.ReadLine();
            theJournal.SaveToFile(file);
        }
    }
}