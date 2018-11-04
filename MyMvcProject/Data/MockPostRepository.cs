using System;
using System.Collections.Generic;
using System.Linq;
using MyMvcProject.Models;

namespace MyMvcProject.Data
{
    public class MockPostRepository : IPostRepository
    {

        private List<PostDTO> posts;

        public MockPostRepository()
        {
            if (posts == null)
            {
                AddPosts();
            }
        }

        private void AddPosts()
        {
            posts = new List<PostDTO>()
            {
                new PostDTO("Tytul1","sadsadasd asd safd asd asd a dasd asd d asd asd asd assf ag ",new DateTime(2018,8,8,12,22,2),new DateTime(2018,8,8,12,22,2)),
                new PostDTO("Dwa","hgjgfhd a dasd asd d asd asd asd assf ag ",new DateTime(2018,8,12,12,22,2),new DateTime(2018,8,8,12,22,2)),
                new PostDTO("Trzy","sfgvnbvbnvbnvbn asd asd a dasd asd d asd asd asd assf ag ",new DateTime(2018,8,14,12,22,2),new DateTime(2018,8,8,12,22,2)),
                new PostDTO("Cztery","ppopiuuyiyuoyuoyuioiuasd asd d asd asd asd assf ag ",new DateTime(2018,8,22,12,22,2),new DateTime(2018,8,8,12,22,2)),
                new PostDTO("Pięć","6556jhggd asd a dasd asd d asd asd asd assf ag ",new DateTime(2018,8,28,12,22,2),new DateTime(2018,8,8,12,22,2)),
                new PostDTO("Sześć","097678ghnn6n65d asd asd assf ag ",new DateTime(2018,9,8,12,22,2),new DateTime(2018,8,8,12,22,2)),
                new PostDTO("Siedem","qweqweqeqweqewd a dasd asd d asd asd asd assf ag ",new DateTime(2018,9,9,12,22,2),new DateTime(2018,8,8,12,22,2))
            };
        }

        public IEnumerable<PostDTO> GetAllPosts()
        {
            return posts;
        }

        public PostDTO GetPost(int id)
        {
            return posts.FirstOrDefault(p => p.Id == id);
        }

        public void CreatePost(PostDTO post)
        {
            throw new NotImplementedException();
        }

        public void UpdatePost(PostDTO post)
        {
            throw new NotImplementedException();
        }

        public void DeletePost(PostDTO post)
        {
            throw new NotImplementedException();
        }
    }
}