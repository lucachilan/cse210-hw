// stores a list of journal entries and saves and displays the journal files
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry()
    {
        
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
    public void SaveToFile()
    {
        
    }
    // load the file
    public void LoadFromFile()
    {
        
    }

}