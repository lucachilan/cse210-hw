public class ListingActivity : Activity
{
    static string description= "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    int _count = 0;
    List<string> _prompts = ["Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"];
    List<int> usedPrompts = []; //index for the used prompts. 
    Random Random = new Random();
    int randomIndex;


    public ListingActivity() : base("Listing",description)
    {
        
    }
    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        Console.WriteLine($"List as many responses you can to the following prompt:\n\n--- {_prompts[randomIndex]} --- ");
        Console.Write("You may begin in: ");
        ShowCountDown(4);
        _count = GetListFromUser().Count;
        Console.WriteLine($"You Listed {_count} items");
        DisplayEndingMessage();

    }
    public void GetRandomPrompt()
    {
        if (usedPrompts.Count == _prompts.Count)
        {
            usedPrompts.Clear();
        }
        do {
            randomIndex = Random.Next(_prompts.Count);
        }while (usedPrompts.Contains(randomIndex));
        usedPrompts.Add(randomIndex);
    }

    public List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());
        DateTime currentTime = DateTime.Now;
        List<string> answers = [];
        Console.WriteLine();
        while (currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            Console.Write("> ");
            string answer = Console.ReadLine();
            answers.Add(answer);
        }
        return answers;
    }
}