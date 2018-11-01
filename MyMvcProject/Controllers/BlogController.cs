using Microsoft.AspNetCore.Mvc;

namespace MyMvcProject.Controllers
{
    public class BlogController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return
            View();
        }
    }
}