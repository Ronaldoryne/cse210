using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        // Create videos
        var firstVideo = new Video("Video 1", "Author 1", 300);
        var secondVideo = new Video("Video 2", "Author 2", 200);
        var thirdVideo = new Video("Video 3", "Author 3", 400);

        // Add comments to videos
        firstVideo.AddComment(new Comment("Commenter 1", "This is a great video!"));
        firstVideo.AddComment(new Comment("Commenter 2", "I agree, it's very informative."));
        secondVideo.AddComment(new Comment("Commenter 3", "This video is okay, but it's not my favorite."));
       thirdVideo.AddComment(new Comment("Commenter 4", "I love this video! It's so funny."));

        // Create list of videos
        var videos = new List<Video> { firstVideo, secondVideo, thirdVideo };

        // Display video information and comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Comment Count: {video.GetCommentCount()}");
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}


