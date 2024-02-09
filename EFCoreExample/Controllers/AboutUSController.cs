using Microsoft.AspNetCore.Mvc;

namespace EFCoreExample.Controllers
{
    public class AboutUSController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
