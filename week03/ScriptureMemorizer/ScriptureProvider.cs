public class ScriptureProvider()
{
    public Scripture GetRandomScripture()
    {
        string wholeScripture = GetScriptureFromFile();
        string[] parts = wholeScripture.Split('|');
        string book = parts[0].Trim();
        int chapter = int.Parse(parts[1].Trim());
        int verse = int.Parse(parts[2].Trim());
        int endVerse = int.Parse(parts[3].Trim());
        string text = parts[4].Trim();

        Reference reference = new Reference(book, chapter, verse, endVerse);
        Scripture scripture = new Scripture(reference, text);
        return scripture;
    }

    static string filename = "scriptures.txt";
    private string GetScriptureFromFile()
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        Random random = new Random();
        int rndIndex = random.Next(lines.Count());
        string wholeVerse = lines[rndIndex]; 
    
        return wholeVerse;
    }
}