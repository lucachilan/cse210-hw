// represents a single journal entry
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    
    string responseText;

    public void Display()
    {
        responseText = $"{_date} - {_promptText}\n{_entryText}";
        Console.WriteLine(responseText);
    }
}

