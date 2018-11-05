using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyMvcProject.Data;
using MyMvcProject.DataMapper;
using MyMvcProject.Models;
using MyMvcProject.ViewModels;

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
            List<PostVM> posts;
            posts = _postRepository.GetAllPosts().OrderByDescending(p => p.PostDate)
                                   .Take(3).Select(p => new PostVM(p)).ToList();

            if (posts == null)
                return NotFound();

            return View(posts);
        }

        public IActionResult PostList()
        {
            var posts = _postRepository.GetAllPosts().OrderByDescending(p => p.PostDate).Select(p => new PostVM(p)).ToList();

            if (posts == null)
                return NotFound();

            return View(posts);
        }

        public IActionResult EditPost(int id)
        {
            var post = _postRepository.GetPost(id);

            if (post == null)
                return NotFound();

            return View(post.MapDTOtoVM());
        }

        [HttpPost]
        public IActionResult EditPost(PostVM post)
        {
            if (ModelState.IsValid)
            {
                post.PostEditDate = DateTime.Now;
                _postRepository.UpdatePost(post.MapVMtoDTO());
                return RedirectToAction("Index");
            }

            return View(post);
        }

        public IActionResult Details(int id)
        {
            var post = _postRepository.GetPost(id);

            if (post == null)
                return NotFound();

            return View(post.MapDTOtoVM());
        }

        public IActionResult DeletePost(int id)
        {
            var post = _postRepository.GetPost(id);

            if (post == null)
                return NotFound();

            return View(post.MapDTOtoVM());
        }

        [HttpPost, ActionName("DeletePost")]
        public IActionResult DeletePostConfirmed(int id)
        {
            var post = _postRepository.GetPost(id);
            _postRepository.DeletePost(post);

            return RedirectToAction("PostList");
        }
    }
}