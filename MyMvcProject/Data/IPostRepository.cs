using MyMvcProject.Models;
using System.Collections.Generic;

namespace MyMvcProject.Data
{
    public interface IPostRepository
    {
        IEnumerable<Post> GetAllPosts();
        Post GetPost(int id);
    }
}