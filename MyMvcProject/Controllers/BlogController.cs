using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyMvcProject.Data;
using MyMvcProject.Models;

namespace MyMvcProject.Controllers
{
    public class BlogController : Controller
    {
        private readonly IPostRepository _postRepository;

        public BlogController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public IActionResult Index()
        {
            var posts = _postRepository.GetAllPosts().OrderByDescending(p => p.PostDate);

            if (posts == null)
                return NotFound();

            return View(posts);
        }

        public IActionResult EditPost(int id)
        {
            var post = _postRepository.GetPost(id);

            if (post == null)
                return NotFound();

            return View(post);
        }

        [HttpPost]
        public IActionResult EditPost(Post post)
        {
            if (ModelState.IsValid)
            {
                post.PostDate = DateTime.Now;
                _postRepository.UpdatePost(post);
                return RedirectToAction("Index");
            }

            return View(post);
        }
    }
}