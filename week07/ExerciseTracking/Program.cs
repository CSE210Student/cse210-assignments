using System;

//https://stackoverflow.com/questions/11634079/how-can-i-get-the-data-type-of-a-variable-in-c

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running run = new Running(30, 3.0);
        activities.Add(run);

        Swimming swim = new Swimming(60, 30);
        activities.Add(swim);

        Cycling bike = new Cycling(45, 5.0);
        activities.Add(bike);

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}