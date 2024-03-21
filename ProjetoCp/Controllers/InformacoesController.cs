using Microsoft.AspNetCore.Mvc;
using ProjetoCp.Models;

namespace ProjetoCp.Controllers
{
    public class InformacoesController : Controller
    {
        public IActionResult Informacoes()
        {
            InformacoesModel informacoes = new InformacoesModel();

            informacoes.Nome = "Izabelly de Oliveira Menezes";
            informacoes.Email = "izahholiveiramenezes@gmail.com";
            informacoes.Experiencia = "Tenho experiência no mercado administrativo, pois administro a empresa dos meus pais";
            informacoes.Educacao = "Estudei no Colégio Adventista de Santo André e Atualmente estudo ADS na FIAP";
            

            return View(informacoes);
        }
    }
}
