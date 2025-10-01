using System.Transactions;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    List<Comment>_comments  = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
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
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length (seconds): {LengthInSeconds}");
        Console.WriteLine($"Number of Comments: {GetnumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment.CommenterName}: {comment.Text}");
        }
    }
}