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

    }

    public void DisplayEndingMessage()
    {

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
            Thread.Sleep(250);
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
        
    }
}