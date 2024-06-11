using Microsoft.AspNetCore.Mvc;
using Sistema_Hotel.Models;
using System.Diagnostics;

namespace Sistema_Hotel.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            HomeModel home = new HomeModel();

            home.Nome = "Matheus Hideki";
            home.Email = "mathideki06@gmail.com";
            return View(home);
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
