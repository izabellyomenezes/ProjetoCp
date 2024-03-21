using Microsoft.AspNetCore.Mvc;
using ProjetoCp.Models;

namespace ProjetoCp.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Contato()
        {
            ContatoModel contato = new ContatoModel();

            contato.Contato = "11979980903";

            return View(contato);
        }
    }
}
