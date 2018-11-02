using System;
using System.Collections.Generic;
using System.Linq;
using MyMvcProject.Models;

namespace MyMvcProject.Data
{
    public class MockPostRepository : IPostRepository
    {

        private List<Post> posts;

        public MockPostRepository()
        {
            if (posts == null)
            {
                AddPosts();
            }
        }

        private void AddPosts()
        {
            posts = new List<Post>()
            {
                new Post("Tytul1","sadsadasd asd safd asd asd a dasd asd d asd asd asd assf ag ",new DateTime(2018,8,8,12,22,2)),
                new Post("Dwa","hgjgfhd a dasd asd d asd asd asd assf ag ",new DateTime(2018,8,12,12,22,2)),
                new Post("Trzy","sfgvnbvbnvbnvbn asd asd a dasd asd d asd asd asd assf ag ",new DateTime(2018,8,14,12,22,2)),
                new Post("Cztery","ppopiuuyiyuoyuoyuioiuasd asd d asd asd asd assf ag ",new DateTime(2018,8,22,12,22,2)),
                new Post("Pięć","6556jhggd asd a dasd asd d asd asd asd assf ag ",new DateTime(2018,8,28,12,22,2)),
                new Post("Sześć","097678ghnn6n65d asd asd assf ag ",new DateTime(2018,9,8,12,22,2)),
                new Post("Siedem","qweqweqeqweqewd a dasd asd d asd asd asd assf ag ",new DateTime(2018,9,9,12,22,2))
            };
        }

        public IEnumerable<Post> GetAllPosts()
        {
            return posts;
        }

        public Post GetPost(int id)
        {
            return posts.FirstOrDefault(p => p.Id == id);
        }
    }
}