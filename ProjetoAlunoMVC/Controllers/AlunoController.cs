using Microsoft.AspNetCore.Mvc;

namespace ProjetoAlunoMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nome = "Cauã";
            ViewBag.Curso = "Tecnologia em Analise e Desenvolvimento de Sistemas";
            ViewBag.Semestre = "1º Semestre";

            return View();
        }
    }
}