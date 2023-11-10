using Microsoft.AspNetCore.Mvc;

namespace WebDev.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
