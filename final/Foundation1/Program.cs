using System;

public class Program {
    static void Main(string[] args) {
        List<Video> videos = new List<Video>();

        // create 3-4 videos and add comments to them
        Video video1 = new Video("Video 1", "Author 1", 120);
        video1.AddComment(new Comment { Name = "Commenter 1", Text = "Great video!" });
        video1.AddComment(new Comment { Name = "Commenter 2", Text = "I learned a lot." });
        videos.Add(video1);

        Video video2 = new Video("Video 2", "Author 2", 180);
        video2.AddComment(new Comment { Name = "Commenter 1", Text = "This was helpful." });
        video2.AddComment(new Comment { Name = "Commenter 3", Text = "Could you explain more about X?" });
        video2.AddComment(new Comment { Name = "Commenter 4", Text = "Thanks for sharing." });
        videos.Add(video2);

        Video video3 = new Video("Video 3", "Author 3", 90);
        video3.AddComment(new Comment { Name = "Commenter 5", Text = "I disagree with your point." });
        videos.Add(video3);

        // iterate through the list of videos and display the information
        foreach (Video video in videos) {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of comments: " + video.GetCommentCount());
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.Comments) {
                Console.WriteLine(comment.Name + ": " + comment.Text);
            }

            Console.WriteLine();
        }
    }
}