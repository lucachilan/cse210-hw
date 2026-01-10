// supplies random prompts whenever needed
public class PromptGenerator
{
    // grab a list of prompts 
    public List<string> _prompts = new List<string>();
    static string filename = "prompts.txt";

    public PromptGenerator()
        {
            Files promptFile = new Files();
            _prompts = promptFile.LoadFromFile(filename);  
        }
    // choose a random one from the list
    // return one prompt
    public string GetRandomPrompt()
    {
        Random random = Random.Shared;
        int randomIndex =random.Next(_prompts.Count);

        string promptText = _prompts[randomIndex];
        Console.WriteLine(promptText);

        return promptText;
    }
}