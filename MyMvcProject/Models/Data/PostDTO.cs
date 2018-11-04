using System;
using System.ComponentModel.DataAnnotations;

namespace MyMvcProject.Models
{
    public class PostDTO
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string PostText { get; set; }
        public DateTime PostDate { get; set; }
        public DateTime PostEditDate { get; set; }

        public PostDTO()
        {
        }

        public PostDTO(string title, string postText, DateTime postDate, DateTime postEditDate)
        {
            Title = title;
            PostText = postText;
            PostDate = postDate;
            PostEditDate = postEditDate;
        }
    }
}