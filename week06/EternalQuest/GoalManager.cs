using System.Diagnostics;
using System.Net.Quic;
using System.Security.Cryptography.X509Certificates;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private string _rank;
    private int _needed;
    private bool _quit = false;

    public GoalManager()
    {

    }

    public void Start()
    {
        do
        {
            Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("Select a choice from the menu: ");
            int _choice = int.Parse(Console.ReadLine());

            switch (_choice)
            {
                case 1:
                    CreateGoal();
                    break;

                case 2:
                    ListGoalNames();
                    break;

                case 3:
                    SaveGoals();
                    break;

                case 4:
                    LoadGoals();
                    break;

                case 5:
                    RecordEvent();
                    break;

                case 6:
                    _quit = true;
                    break;

                default:
                    Console.WriteLine("That is not an option, please try again.");
                    break;
            }
        } while (_quit != true);
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Rank: {Rank()}");
        Console.WriteLine($"Score: {_score}");
        Console.WriteLine($"Next Rank in: {_needed}");
    }

    public void ListGoalNames()
    {

    }

    public void ListGoalDetails()
    {

    }

    public void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("Create a new goal");
        Console.WriteLine("   1. Eternal Goal");
        Console.WriteLine("   2. Checklist Goal");
        Console.WriteLine("   3. Simple Goal");
        Console.Write("Choose a goal type: ");
        int _typeChoice = int.Parse(Console.ReadLine());

        Console.WriteLine("");

        Console.Write("Enter Goal Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter a description for the goal: ");
        string description = Console.ReadLine();

        Console.WriteLine("How many points is this goal worth: ");
        int points = int.Parse(Console.ReadLine());

        do
        {
            switch (_typeChoice)
            {
                case 1:
                    EternalGoal eg1 = new EternalGoal(name, description, points);
                    _goals.Add(eg1);
                    break;

                case 2:
                    Console.WriteLine("");
                    Console.Write("How many times is this goal to be completed; ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("How many bonus points for meeting the target: ");
                    int bonus = int.Parse(Console.ReadLine());

                    ChecklistGoal cg1 = new ChecklistGoal(name, description, points, target, bonus);
                    _goals.Add(cg1);
                    break;

                case 3:
                    SimpleGoal sg1 = new SimpleGoal(name, description, points);
                    _goals.Add(sg1);
                    break;

                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        } while (_typeChoice != 1 | _typeChoice != 2 | _typeChoice != 3);
    }

    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }

    public string Rank()
    {
        if (_score >= 10000000)
        {
            _rank = "Diamond";
        }

        else if (_score >= 1000000)
        {
            _rank = "Aventurine";
        }

        else if (_score >= 750000)
        {
            _rank = "Opal";
        }

        else if (_score >= 500000)
        {
            _rank = "Jade";
        }

        else if (_score >= 250000)
        {
            _rank = "Sugilite";
        }

        else if (_score >= 100000)
        {
            _rank = "Obsidian";
        }

        else if (_score >= 75000)
        {
            _rank = "Agate";
        }

        else if (_score >= 50000)
        {
            _rank = "Pearl";
        }

        else if (_score >= 25000)
        {
            _rank = "Sapphire";
        }

        else if (_score >= 1000)
        {
            _rank = "Topaz";
        }

        else if (_score >= 0)
        {
            _rank = "Amber";
        }
        return _rank;
    }
}