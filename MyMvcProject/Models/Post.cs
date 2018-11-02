using System;

namespace MyMvcProject.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PostText { get; set; }
        public DateTime PostDate { get; set; }

        public Post()
        {
        }

        public Post(string title, string postText, DateTime postDate)
        {
            Title = title;
            PostText = postText;
            PostDate = postDate;
        }
    }
}