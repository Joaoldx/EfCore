using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class CategoryController : Controller
    {

        [HttpGet]
        public IActionResult Save(){
            return View();
        }

        [HttpPost]
        public IActionResult Index(){
            return View();
        }
    }
}