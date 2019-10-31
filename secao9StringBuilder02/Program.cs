using secao9StringBuilder02.Entites;
using System;

namespace secao9StringBuilder02
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");

            Post post1 = new Post(DateTime.Parse("21/06/2018 13:05:44"), "Traveling to New Zealand",
                                                 "I'm going to visit this wonderful country!", 12);
            post1.AddComment(c1);
            post1.AddComment(c2);

            Console.WriteLine(post1);
        }
    }
}
