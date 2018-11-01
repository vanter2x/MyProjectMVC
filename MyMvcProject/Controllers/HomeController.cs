using Microsoft.AspNetCore.Mvc;

namespace MyMvcProject.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}