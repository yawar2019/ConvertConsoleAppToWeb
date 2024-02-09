using FirstMvcCoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using FirstMvcCoreApp.Reposiotry;
using FirstMvcCoreApp.IRepository;

namespace FirstMvcCoreApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentReposiotryModel _studentReposiotry;
        private readonly IConfiguration _configuration;
        public HomeController(ILogger<HomeController> logger, IStudentReposiotryModel studentReposiotry, IConfiguration configuration)
        {
            _logger = logger;
            _studentReposiotry = studentReposiotry;
            _configuration = configuration;
        }

        public ActionResult Index()
        {
            //StudentReposiotryModel st = new StudentReposiotryModel();
            //var result = st.GetStudentDetails();
            //string? TestName = _configuration.GetValue<string>("Test");
            //var Name1 = _configuration.GetSection("app:user");
            //string? Name2 = _configuration.GetSection("app").GetValue<string>("Roles:user");
            // User Name3 = _configuration.GetSection("app:User").Get<User>();
            var Connectionstring = _configuration.GetConnectionString("SqlCon");
            var result = _studentReposiotry.GetStudentDetails();
            return View(result);
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
    }
}