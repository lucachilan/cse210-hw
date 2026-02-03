public class WritingAssigment : Assigment
{
    private string _title = "";

    public WritingAssigment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{GetSummary()}\nTitle {_title} by {GetStudentName()}";
    }
}