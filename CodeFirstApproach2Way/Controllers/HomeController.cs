using CodeFirstApproach2Way.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CodeFirstApproach2Way.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StaffContext _staffcontext;

        public HomeController(ILogger<HomeController> logger, StaffContext staffcontext)
        {
            _logger = logger;
            _staffcontext = staffcontext;
        }

        public IActionResult Index()
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

            return View(_staffcontext.staffModels.ToList());
        }
    }
}