using Microsoft.AspNetCore.Mvc;

namespace MVCBlog.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
