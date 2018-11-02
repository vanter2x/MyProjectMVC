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

        public IEnumerable<Post> GetAllPosts()
        {
            return _appDbContext.Posts;
        }

        public Post GetPost(int id)
        {
            return _appDbContext.Posts.FirstOrDefault(p => p.Id == id);
        }

        public void CreatePost(Post post)
        {
            _appDbContext.Add(post);
            _appDbContext.SaveChanges();
        }

        public void UpdatePost(Post post)
        {
            _appDbContext.Update(post);
            _appDbContext.SaveChanges();
        }

        public void DeletePost(Post post)
        {
            _appDbContext.Remove(post);
            _appDbContext.SaveChanges();
        }
    }
}