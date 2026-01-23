public class Comment
{
    private string _name;
    private string _commentText;
    public Comment(string text)
    {
        String[] commentElements = text.Split(":");
        _name = commentElements[0].Trim();
        _commentText = commentElements[1].Trim();
    }
    public string GetCommentText()
    {
        return $"'{_name}' said: {_commentText}";
    }
}