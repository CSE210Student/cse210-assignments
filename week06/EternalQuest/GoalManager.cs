using System.Diagnostics;
using System.Net.Quic;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private string _rank;
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
                    ListGoalDetails();
                    Console.WriteLine("");
                    Console.Write("Press Enter to continue");
                    Console.ReadLine();
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

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"Rank: {Rank()}");
        Console.WriteLine($"Score: {_score}");
    }

    private void ListGoalNames()
    {
        int i = 0;
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{i + 1}. {goal.GetName()}");
            i++;
        }
    }

    private void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    private void CreateGoal()
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

        Console.Write("How many points is this goal worth: ");
        int points = int.Parse(Console.ReadLine());

        switch (_typeChoice)
        {
            case 1:
                EternalGoal eg1 = new EternalGoal(name, description, points);
                _goals.Add(eg1);
                break;

            case 2:
                Console.Write("How many bonus points for meeting the target: ");
                int bonus = int.Parse(Console.ReadLine());
                Console.Write("How many times is this goal to be completed: ");
                int target = int.Parse(Console.ReadLine());

                ChecklistGoal cg1 = new ChecklistGoal(name, description, points, bonus, target);
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
    }

    private void RecordEvent()
    {
        Console.Clear();
        ListGoalNames();
        Console.WriteLine("");
        Console.Write("Record an event for which goal: ");
        int recordedGoal = int.Parse(Console.ReadLine());
        recordedGoal--;

        _score += _goals[recordedGoal].RecordEvent();
    }

    private void SaveGoals()
    {
        Console.Clear();

        Console.Write("Enter File Name: ");
        string file = Console.ReadLine();

        Console.WriteLine("Saving File...");
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_score);
            foreach (Goal i in _goals)
            {
                outputFile.WriteLine(i.GetStringRepresentation());
            }
        }
    }

    private void LoadGoals()
    {
        Console.Clear();
        Console.Write("Enter File Name: ");
        string file = Console.ReadLine();

        Console.WriteLine("Loading File...");

        string[] lines = System.IO.File.ReadAllLines(file);

        _score = int.Parse(lines[0]);
        lines = lines.Skip(1).ToArray();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string goalType = parts[0];
            string goalName = parts[1];
            string goalDescription = parts[2];

            if (goalType == "SimpleGoal")
            {
                bool completeStatus = bool.Parse(parts[4]);
                _goals.Add(new SimpleGoal(goalName, goalDescription, int.Parse(parts[3])));
            }

            else if (goalType == "EternalGoal")
            {
                _goals.Add(new EternalGoal(goalName, goalDescription, int.Parse(parts[3])));
            }

            else if (goalType == "ChecklistGoal")
            {
                int bonus = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int completed = int.Parse(parts[6]);
                _goals.Add(new ChecklistGoal(goalName, goalDescription, int.Parse(parts[3]), bonus, target, completed));
            }
        }
            
    }

    private string Rank()
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