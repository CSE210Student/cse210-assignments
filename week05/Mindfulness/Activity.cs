public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name}.");
        Console.Write($"\n{_description}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\n\nWay to go superstar!");
        Console.WriteLine($"You have completed another {_duration} seconds of {_name}.");
        ShowSpinner(3);
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinnerStrings =
        [
            "|",
            "/",
            "-",
            "\\",
            "|",
            "/",
            "-",
            "\\",
        ];


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string spin = spinnerStrings[i];
            Console.Write(spin);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= spinnerStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}