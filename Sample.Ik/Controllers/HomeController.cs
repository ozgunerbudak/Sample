using Microsoft.AspNetCore.Mvc;
using Sample.BL;
using Sample.Ik.Models;
using System.Diagnostics;

namespace Sample.Ik.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        //private readonly IUserService _userService;
        //public HomeController(ILogger<HomeController> logger, IUserService userService)
        //{
        //    _logger = logger;
        //    this._userService = userService;
        //}

        public IActionResult Index()
        {
            var currentDate = DateTime.Now;
            TimeSpan time = currentDate.TimeOfDay;

            var asda = currentDate.ToString("HH:mm");
            //var userListesi = _userService.GetAllUser();
            return View();
        }

        public IActionResult CreateUser([FromForm] string userName)
        {
            //_userService.CreateUser();
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
    }
}