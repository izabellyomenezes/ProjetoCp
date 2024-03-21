using Microsoft.AspNetCore.Mvc;
using ProjetoCp.Models;
using System.Diagnostics;

namespace ProjetoCp.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            HomeModel home = new HomeModel();

            home.Nome = "Caio Halbert Jacinto";
            home.Funcao = "Professor";

            return View(home);
        }

    }
}