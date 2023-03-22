using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._author = "John";
        video1._title = "How to tie your shoes";
        video1._length = 63;

        Comment comment1 = new Comment();
        comment1._name = "billy76";
        comment1._comment = "How are there some many ways to tie shoes?";
        comment1.MakeComment();
        video1._comments.Add(comment1._fullComment);
        comment1._name = "NoMan092";
        comment1._comment = "I can tie my shoes about 20 seconds faster then he can.";
        comment1.MakeComment();
        video1._comments.Add(comment1._fullComment);
        comment1._name = "Sue Ly";
        comment1._comment = "This helped me a lot! Thank you!";
        comment1.MakeComment();
        video1._comments.Add(comment1._fullComment);

        video1.Display();

        Video video2 = new Video();
        video2._author = "DJ_Paxman";
        video2._title = "Disco Stream";
        video2._length = 5103;

        Comment comment2 = new Comment();
        comment2._name = "Disco Lover 1993";
        comment2._comment = "YESSSSSSSSSSSS! Keep making more stuff like this!";
        comment2.MakeComment();
        video2._comments.Add(comment2._fullComment);
        comment2._name = "Phill";
        comment2._comment = "I wish I was born in the disc age.";
        comment2.MakeComment();
        video2._comments.Add(comment2._fullComment);
        comment2._name = "8879X";
        comment2._comment = "Disco is meh but I like your video editing.";
        comment2.MakeComment();
        video2._comments.Add(comment2._fullComment);

        video2.Display();

        Video video3 = new Video();
        video3._author = "RPG Reviewer";
        video3._title = "Hero Quext review ";
        video3._length = 63;

        Comment comment3 = new Comment();
        comment3._name = "FF Lover1-16";
        comment3._comment = "You should review FF 16 soon!";
        comment3.MakeComment();
        video3._comments.Add(comment3._fullComment);
        comment3._name = "A wild Fenrir Apeared!";
        comment3._comment = "You made some good points about the combat system, this helps me a bunch!";
        comment3.MakeComment();
        video3._comments.Add(comment3._fullComment);
        comment3._name = "NoMan092";
        comment3._comment = "I can review games 8 hours quicker then you can.";
        comment3.MakeComment();
        video3._comments.Add(comment3._fullComment);
        comment3._name = "Katie";
        comment3._comment = "new vid! Yes!!!";
        comment3.MakeComment();
        video3._comments.Add(comment3._fullComment);

        video3.Display();
    }
}