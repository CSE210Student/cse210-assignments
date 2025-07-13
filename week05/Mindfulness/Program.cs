using System;
using System.Xml.Serialization;

//https://www.w3schools.com/cs/cs_switch.php#:~:text=C%23%20Switch%20Statements,code%20blocks%20to%20be%20executed.

//For exceeding requirements and dhowing creativty:
//I decided to add a word association acitivty. The user is given a random word
//and then gives the first word that it makes them think of.
//This continues untill the duration given by the user is done.

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        Console.Clear();

        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start BREATHING activity");
            Console.WriteLine("2. Start REFLECTING activity");
            Console.WriteLine("3. Start LISTING activity");
            Console.WriteLine("4. Start WORD ASSOCIATION activity");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice fomr the menu: ");
            string userChoice = Console.ReadLine();
            choice = int.Parse(userChoice);

            switch (choice)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;
                case 2:
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    break;
                case 3:
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;
                case 4:
                    WordAssociationActivity wordAssociation = new WordAssociationActivity();
                    wordAssociation.Run();
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Please enter a valid menu option.");
                    break;

            }

        } while (choice != 4);
    }
}