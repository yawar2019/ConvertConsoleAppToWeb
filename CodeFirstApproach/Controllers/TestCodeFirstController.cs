using CodeFirstApproach.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstApproach.Controllers
{
    public class TestCodeFirstController : Controller
    {
        public readonly IConfiguration _config;
        public TestCodeFirstController(IConfiguration config)
        {
            _config = config;
        }

        EmployeeContext db = new EmployeeContext();
        public IActionResult Index()
        {

            return View(db.EmployeeModels.ToList());
        }
    }
}
