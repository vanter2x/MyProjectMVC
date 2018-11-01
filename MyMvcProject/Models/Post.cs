﻿using System;

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

        public Post(int id, string title, string postText, DateTime postDate)
        {
            Id = id;
            Title = title;
            PostText = postText;
            PostDate = postDate;
        }
    }
}