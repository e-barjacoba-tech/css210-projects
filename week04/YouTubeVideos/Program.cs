using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string author1 = "Ezequiel Barjacoba";
        string t1 = "Pokemon Legends Z-A";

        string author2 = "Matias Cabrera";
        string t2 = "Pokemon Legends Arceus";

        string author3 = "Tim Payne";
        string t3 = "NZ road to World Cup";

        List<Video> videosList = new List<Video>();

        Video video1 = new Video(t1, author1, 600);
        Comment comment1 = new Comment("This game is fantastic!", "lorenzo13!");
        video1.AddComment(comment1);
        Comment comment2 = new Comment("I think it could have better graphics", "r0x4nn33");
        video1.AddComment(comment2);
        Comment comment3 = new Comment("This Pokemon game is quite addictive", "pikapower");
        video1.AddComment(comment3);
        videosList.Add(video1);

        Video video2 = new Video(t2, author2, 1000);
        Comment comment1B = new Comment("I prefer this one to Pokemon Legends Z-A", "cassaNdra2");
        video2.AddComment(comment1B);
        Comment comment2B = new Comment("It is a Breath of the Wild for Pokemon!", "newUser0P");
        video2.AddComment(comment2B);
        Comment comment3B = new Comment("Achei o jogo legal, mas tem problemas com os graficos", "brPlayer");
        video2.AddComment(comment3B);
        videosList.Add(video2);

        Video video3 = new Video(t3,author3, 1989);
        Comment comment1C = new Comment("I don't know you but you're my hero", "santyzz");
        video3.AddComment(comment1C);
        Comment comment2C = new Comment("My kids will have your name", "nzTeam");
        video3.AddComment(comment2C);
        Comment comment3C = new Comment("We made the right guy famous", "unknown^_^");
        video3.AddComment(comment3C);
        videosList.Add(video3);

        foreach (Video i in videosList)
        {
            Console.WriteLine(i.DisplayDetails());
        }
    }
}