using Microsoft.AspNetCore.Mvc;
using Web_Franco.Models;

namespace Web_Franco.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var personalInfo = new PersonalInfo();
            var educacion = new Educacion();
            var experiencia = new Experiencia();
            var habilidadesDuras = HabilidadesPredefinidas.ObtenerHabilidadesDuras();
            var habilidadesBlandas = HabilidadesPredefinidas.ObtenerHabilidadesBlandas();

            ViewBag.PersonalInfo = personalInfo;
            ViewBag.Educacion = educacion;
            ViewBag.Experiencia = experiencia;
            ViewBag.HabilidadesDuras = habilidadesDuras;
            ViewBag.HabilidadesBlandas = habilidadesBlandas;
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}