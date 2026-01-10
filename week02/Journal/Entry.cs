// represents a single journal entry
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"{_date} - {_promptText}\n{_entryText}");
    }

}