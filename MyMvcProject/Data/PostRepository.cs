using System.Collections.Generic;
using System.Linq;
using System.Threading;
using MyMvcProject.Models;

namespace MyMvcProject.Data
{
    public class PostRepository : IPostRepository
    {
        private readonly AppDbContext _appDbContext;

        public PostRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<PostDTO> GetAllPosts()
        {
            return _appDbContext.Posts;
        }

        public PostDTO GetPost(int id)
        {
            return _appDbContext.Posts.FirstOrDefault(p => p.Id == id);
        }

        public void CreatePost(PostDTO post)
        {
            _appDbContext.Add(post);
            _appDbContext.SaveChanges();
        }

        public void UpdatePost(PostDTO post)
        {
            _appDbContext.Update(post);
            _appDbContext.SaveChanges();
        }

        public void DeletePost(PostDTO post)
        {
            _appDbContext.Remove(post);
            _appDbContext.SaveChanges();
        }
    }
}