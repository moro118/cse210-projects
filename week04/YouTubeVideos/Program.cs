using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        videos.Add(new Video("C# Tutorial for Beginners", "John Doe", 600));
        videos.Add(new Video("Learn Python in 10 Minutes", "Jane Smith", 300));
        videos.Add(new Video("JavaScript Basics", "Alice Johnson", 450));
        videos[0].AddComment(new Comment("User1", "Great tutorial!"));
        videos[0].AddComment(new Comment("User2", "Very helpful, thanks!"));
        videos[0].AddComment(new Comment("User7", "Well explained."));
        videos[1].AddComment(new Comment("User3", "I learned a lot!"));
        videos[1].AddComment(new Comment("User4", "Clear and concise."));
        videos[1].AddComment(new Comment("User8", "Perfect for beginners."));
        videos[2].AddComment(new Comment("User5", "Good introduction to JS."));
        videos[2].AddComment(new Comment("User6", "Thanks for sharing!"));
        videos[2].AddComment(new Comment("User9", "Very informative."));
        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine();
        }
    }
}