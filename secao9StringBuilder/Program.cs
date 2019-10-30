using secao9StringBuilder.Entites;
using System;

namespace secao9StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment comment01 = new Comment("Have a nice trip!!!");
            Comment comment02 = new Comment("Wow that's awesome.");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"), "Traveling to New Zealand", "I'm going to visit Austrtalia", 2
                );
            p1.AddComment(comment01);
            p1.AddComment(comment02);



        }
    }
}
