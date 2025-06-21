public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What are you grateful for?");
        _prompts.Add("What would make the day great?");
        _prompts.Add("What lesson did you learn today? ");
        _prompts.Add("Describe a choice you regret. What did you learn from it?");
        _prompts.Add("What three ordinary things bring you the most joy?");
        _prompts.Add("What aspects of your life are you most grateful for?");
        _prompts.Add("What place makes you feel most peaceful?");
        _prompts.Add("List 10 things that inspire or motivate you.");
        _prompts.Add("What do you look forward to most in the future?");
        _prompts.Add("What is a skill you would like to develop in the next five years?");
        _prompts.Add("How will you know when you have reached ultimate success?");
        _prompts.Add("Explain something you believed as a child that now makes you laugh.");
        _prompts.Add("Name one song that means a lot to you. What does it remind you of? What does it mean to you? Why is it important to you?");

        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count);
        string _prompt = _prompts[index];

        return _prompt;
    }
}