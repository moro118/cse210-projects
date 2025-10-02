using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    List<Comment>_comments  = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }
   public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    int GetnumberOfComments()
    {
        return _comments.Count;
    }
    public void Display()
    { 
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length (seconds): {_lengthInSeconds}");
        Console.WriteLine($"Number of Comments: {GetnumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetCommenterName()}: {comment.GetText()}");
        }
    }
}