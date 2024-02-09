using DataBaseFirstApproach.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DataBaseFirstApproach.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(TestHtmlHelper helper)
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult GetStudentData()
        {
            StudentDbContext db = new StudentDbContext();
        
            return View(db.Students.ToList());
        }

        public IActionResult GetTagHelperExample()
        {
            return View();
        }
        [Route("/Movie/Avengers", Name = "Avengers")]
    public IActionResult GetTagHelperExample2()
        {
            return View();
        }
    }
}