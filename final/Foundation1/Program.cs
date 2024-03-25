using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to make the perfect Paper Airplane", "FranzScience", 112.32);
        Comment comment1 = new Comment("Wow! I'm definitely going to win the paper airplane contest now!","AverageUser");
        Comment comment2 = new Comment("What was the fold he made at the 17 second mark????","ConfusedGus");
        Comment comment3 = new Comment("You should do another video where you make the worst airplane possible","MarkCube");
        Comment comment4 = new Comment("Great Video Very Helpful!","PositivePam");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        video1.AddComment(comment4);

        Video video2 = new Video("How to calculate the area of a circle!","MathTutorFrank",421.32);
        Comment comment5 = new Comment("Great video Frank! It totally makes sense!","StudentStew");
        Comment comment6 = new Comment("I'm confused on the part where you said the circle is not a square?????","ConfusedGus");
        Comment comment7 = new Comment("Great video! Although I think you accidently had a negative sign in your third equation","ExactoEthan");
        Comment comment8 = new Comment("Can you do a pentagon in your next video?","VictorViewer");
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video2.AddComment(comment7);
        video2.AddComment(comment8);

        Video video3 = new Video("Football Highlights (2023-2024)","FootballHighlighter",1083.34);
        Comment comment9 = new Comment("Wow that hit at 3.14 was crazy!","CrazedFootballFan");
        Comment comment10 = new Comment("I thought this was going to be a cool soccer video. Now I'm sad.","EuropeanJoe");
        Comment comment11 = new Comment("I thought for sure that the 49ers would win the superbowl this year","49ers4life");
        Comment comment12 = new Comment("Patrick Mahomes is the best!","MahomesYoungerBrother");
        video3.AddComment(comment9);
        video3.AddComment(comment10);
        video3.AddComment(comment11);
        video3.AddComment(comment12);

        List<Video> videos = new List<Video>{video1, video2, video3};
        foreach(Video video in videos){
            video.DisplayBaseInfo();
        }
    }
}