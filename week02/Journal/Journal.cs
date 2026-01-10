// stores a list of journal entries and saves and displays the journal files
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    PromptGenerator prompt = new PromptGenerator();
    public void AddEntry()
    {
        Entry entry = new Entry();

        DateTime theCurrentTime = DateTime.Now;
        entry._date=theCurrentTime.ToShortDateString();
        entry._promptText = prompt.GetRandomPrompt();
        entry._entryText = Console.ReadLine();
        _entries.Add(entry);
    }
    // display the entries
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // save the file
    public void SaveToFile(string filename)
    {
        Files journalFile = new Files();
        string fileContent = "";
        foreach (Entry entry in _entries)
        {
            fileContent += entry._date + ";" + entry._promptText + ";" + entry._entryText + "\n";
        } 
        journalFile.WriteInFile(filename,fileContent);
    }

    // load the file
    public void LoadFromFile(string filename)
    {   
        List<string> journalLines = new List<string>();
        Files journalFile = new Files();
        
        journalLines = journalFile.LoadFromFile(filename);
        _entries = [];
        foreach (string line in journalLines)
        {
            Entry loadingEntry = new Entry();
            string[] fields = line.Split(";");
            loadingEntry._date=fields[0];
            loadingEntry._promptText=fields[1];
            loadingEntry._entryText=fields[2];
            _entries.Add(loadingEntry);
        }
    }
}