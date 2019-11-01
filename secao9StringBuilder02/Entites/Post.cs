using System;
using System.Collections.Generic;
using System.Text;

namespace secao9StringBuilder02.Entites
{
    class Post
    {
        public DateTime Momment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {
        }
        public Post(DateTime momment, string title, string content, int likes)
        {
            Momment = momment;
            Title = title;
            Content = content;
            Likes = likes;
        }
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }
        public override string ToString()
        {
            StringBuilder p = new StringBuilder();
            p.AppendLine(Title);
            p.Append(Likes);
            p.Append("Likes - ");
            p.AppendLine(Momment.ToString("dd/MM/yyyy HH:mm:SS"));
            p.AppendLine("Comments: ");
            foreach (Comment c in Comments)
            {
                p.AppendLine(c.Text);
            }
            return p.ToString();
        }
    }
}
