public class Video
{
    string _title;
    string _author;
    double _length;

    private List<Comment> _comments = new List<Comment>();

    public Video(string videoText)
    {
        string[] videoDetails = videoText.Split(";");
        _title = videoDetails[0].Trim();
        _author = videoDetails[1].Trim();
        _length = Convert.ToDouble(videoDetails[2]);
        if (videoDetails.Length>=3){
            for (int i = 3; i < videoDetails.Length;i++)
            {
                Comment comment = new Comment(videoDetails[i]);
                _comments.Add(comment);
            }
        }
    }

    public int getNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Video: {_title} by: '{_author}', duration: {_length}, has {getNumberOfComments()} comment(s).");
        foreach(Comment comment in _comments)
        {
            Console.WriteLine(comment.GetCommentText());
        }
    }
}