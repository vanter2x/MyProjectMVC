using Microsoft.AspNetCore.Mvc;
using MyMvcProject.Data;

namespace MyMvcProject.Controllers
{
    public class BlogController : Controller
    {
        private readonly IPostRepository _postRepository;

        public BlogController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        // GET
        public IActionResult Index()
        {
            var posts = _postRepository.GetAllPosts();

            if (posts == null)
                return NotFound();

            return View(posts);
        }
    }
}