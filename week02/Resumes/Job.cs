public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear; 

    public void DisplayJobDescription()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}