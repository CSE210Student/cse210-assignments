using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Xml.Serialization;

//https://stackoverflow.com/questions/1753508/how-could-i-get-a-random-string-from-a-list-and-assign-it-to-a-variable
//https://www.reddit.com/r/learnprogramming/comments/9wqfwf/c_console_color_change_of_single_word/

//EXCEED REQUIREMENTS AND SHOW CREATIVITY
//In addition to the required information that is saved in the file,
//I added a question to ask the users mood and save that as well.
//It lists 4 moods, and colors each mood when it prints them as an option.

class Program
{
    static void Main(string[] args)
    {
        int choice = 10;
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();

        while (choice != 5)
        {
            Console.WriteLine("Welcome to the Journal Program");
            Console.WriteLine("Select a menu option from the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string userChoice = Console.ReadLine();
            choice = int.Parse(userChoice);

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
}