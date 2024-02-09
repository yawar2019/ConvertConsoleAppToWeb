using Microsoft.AspNetCore.Mvc;

namespace ConvertConsoleAppToWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
