using MyMvcProject.Models;
using System.Collections.Generic;

namespace MyMvcProject.Data
{
    public interface IPostRepository
    {
        IEnumerable<PostDTO> GetAllPosts();
        PostDTO GetPost(int id);
        void CreatePost(PostDTO post);
        void UpdatePost(PostDTO post);
        void DeletePost(PostDTO post);
    }
}