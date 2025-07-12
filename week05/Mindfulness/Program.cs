using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        do
        {

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start BREATHING activity");
            Console.WriteLine("2. Start REFLECTING activity");
            Console.WriteLine("3. Start LISTING activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice fomr the menu: >");
            string userChoice = Console.ReadLine();
            choice = int.Parse(userChoice);

            switch (choice)
            {
                case 1:

                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please enter a valid menu option.");
                    break;

            }

        } while (choice != 4);
    }
}