using System.Collections.Generic;
using MyMvcProject.Models;

namespace MyMvcProject.Data
{
    public class PostRepository : IPostRepository
    {
        public IEnumerable<Post> GetAllPosts()
        {
            throw new System.NotImplementedException();
        }

        public Post GetPost(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}