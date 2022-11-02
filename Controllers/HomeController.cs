using Microsoft.AspNetCore.Mvc;

namespace TheASPPractice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
