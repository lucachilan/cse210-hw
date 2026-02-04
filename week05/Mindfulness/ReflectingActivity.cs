public class ReflectingActivity : Activity
{
    static string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    List<string> _prompts = ["Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."];
    List<int> usedPrompts = [];
    List<string> _questions = ["What is your favorite thing about this experience?","What made this time different than other times when you were not as successful?","How did you feel when it was complete?","How did you get started?","Have you ever done anything like this before?","Why was this experience meaningful to you?"];
    List<int> usedQuestions = [];

    Random Random = new Random();


    public ReflectingActivity() : base("Reflecting",description)
    {
        
    }
    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();

        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(4);

        int delayInSec = 10;
        Console.Clear();
        for (double i = delayInSec; i<= GetDuration(); i += delayInSec)
        {
            DisplayQuestion();
            ShowSpinner(delayInSec);
        }
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        if (usedPrompts.Count == _prompts.Count)
        {
            usedPrompts.Clear();
        }
        int randomIndex;
        do {
            randomIndex = Random.Next(_prompts.Count);
        }while (usedPrompts.Contains(randomIndex));

        usedPrompts.Add(randomIndex);
        usedQuestions.Clear(); //with different prompts maybe it's good to answer the same questions. 
        return _prompts[randomIndex];
    }
    public string GetRandomQuestion()
    {
        if (usedQuestions.Count == _questions.Count)
        {
            usedQuestions.Clear();
        }
        int randomIndex2;
        do
        {
            randomIndex2 = Random.Next(_questions.Count);
        } while (usedQuestions.Contains(randomIndex2));

        usedQuestions.Add(randomIndex2);
        return _questions[randomIndex2];
    }
    public void DisplayPrompt()
    {        
        Console.WriteLine($"\nConsider the following prompt:\n\n--- {GetRandomPrompt()} ---");
        Console.WriteLine("When you have something in mind, press <enter> to continue.");
        while(Console.ReadKey(true).Key != ConsoleKey.Enter){}
    }
    public void DisplayQuestion()
    {
        Console.Write($"\n> {GetRandomQuestion()}");
    }
}