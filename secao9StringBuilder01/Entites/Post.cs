using System;
using System.Collections.Generic;
using System.Text;

namespace secao9StringBuilder01.Entites
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public Post()
        {
        }
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
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
            StringBuilder st = new StringBuilder();
            st.AppendLine(Title);
            st.Append(Likes);
            st.Append("Likes - ");
            st.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            st.AppendLine(Content);
            st.AppendLine("Comments: ");
            foreach (Comment c in Comments)
            {
                st.AppendLine(c.Text);
            }
 
           
            return st.ToString();

        }
    }
}
