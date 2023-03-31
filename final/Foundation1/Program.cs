using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("John", "How to tie your shoes", 63);

        Comment comment1 = new Comment("billy76", "How are there some many ways to tie shoes?");
        comment1.MakeComment();
        video1._comments.Add(comment1._fullComment);

        Comment comment2 = new Comment("NoMan092", "I can tie my shoes about 20 seconds faster then he can.");
        comment2.MakeComment();
        video1._comments.Add(comment2._fullComment);

        Comment comment3 = new Comment("Sue Ly", "This helped me a lot! Thank you!");
        comment3.MakeComment();
        video1._comments.Add(comment3._fullComment);

        video1.Display();


        Video video2 = new Video("DJ_Paxman", "Disco Stream", 5103);

        Comment comment4 = new Comment("Disco Lover 1993", "YESSSSSSSSSSSS! Keep making more stuff like this!");
        comment4.MakeComment();
        video2._comments.Add(comment4._fullComment);

        Comment comment5 = new Comment("Phill", "I wish I was born in the disco age.");
        comment5.MakeComment();
        video2._comments.Add(comment5._fullComment);

        Comment comment6 = new Comment("8879X", "Disco is meh but I like your video editing.");
        comment6.MakeComment();
        video2._comments.Add(comment6._fullComment);

        video2.Display();


        Video video3 = new Video("RPG Reviewer", "Hero Quext review", 320);

        Comment comment7 = new Comment("FF Lover1-16", "You should review FF 16 soon!");
        comment7.MakeComment();
        video3._comments.Add(comment7._fullComment);

        Comment comment8 = new Comment("A wild Fenrir Apeared!", "You made some good points about the combat system, this helps me a bunch!");
        comment8.MakeComment();
        video3._comments.Add(comment8._fullComment);

        Comment comment9 = new Comment("NoMan092", "I can review games 8 hours quicker then you can.");
        comment9.MakeComment();
        video3._comments.Add(comment9._fullComment);

        Comment comment10 = new Comment("Katie", "new vid! Yes!!!");
        comment10.MakeComment();
        video3._comments.Add(comment10._fullComment);

        video3.Display();

    }
}