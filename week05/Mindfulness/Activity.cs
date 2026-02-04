public class Activity
{
    string _name = "";
    string _description = "";
    int _duration = 60; //standard duration 60 seconds

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity\n\n{_description}");
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        SetDuration(int.Parse(Console.ReadLine()));
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\n\nWell done!");
        ShowSpinner(2);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(4);
    }
    public void ShowSpinner(int seconds)
    {
        int delay = 350;
        for (double i = 0; i <= seconds; i += delay*4/1000)
        {
            Console.Write("\\");
            Thread.Sleep(delay);
            Console.Write("\b \b|");
            Thread.Sleep(delay);
            Console.Write("\b \b/");
            Thread.Sleep(delay);
            Console.Write("\b \b-");
            Thread.Sleep(delay);
            Console.Write("\b \b");
            
            // for (int j = 0; j < 3; j++)
            // {
            // Console.Write(".");
            // Thread.Sleep(delay);
            // }
            // Console.Write("\b\b\b   \b\b\b");
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i >= 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }   
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public int GetDuration()
    {
        return _duration;
    }

}