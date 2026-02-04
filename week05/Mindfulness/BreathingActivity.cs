public class BreathingActivity : Activity
{
    static string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    public BreathingActivity() : base("Breathing", description)
    {
        
    }
    public void Run()
    {
        DisplayStartingMessage();
        for (int i = 10; i <= GetDuration(); i += 10)
        {
            Console.Write($"\n\nBreathe in... ");
            Thread.Sleep(1000);
            ShowCountDown(4);

            Console.Write("\nNow breathe out... ");
            Thread.Sleep(1000);
            ShowCountDown(4);
        }
        
        DisplayEndingMessage();
    }

}